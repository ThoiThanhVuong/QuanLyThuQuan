using QuanLyThuQuan.BUS;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormDashBoard : Form
    {
        private SessionStudyBUS sessionStudyBUS = new SessionStudyBUS();
        public FormDashBoard()
        {
            InitializeComponent();
            loadTable();
            timer1.Start();
            timer2.Interval = 1000; // 1 giây
            timer2.Tick += timer2_Tick;
            timer2.Start();

            // Kích hoạt vẽ lại Panel mỗi giây
            panelClock.Paint += panelClock_Paint;
        }

        private void loadTable()
        {
            List<SessionStudy> sessionStudies = sessionStudyBUS.GetSessionStudies(); // Giả sử GetActiveViolations lấy danh sách vi phạm
            if (sessionStudies == null)
            {
                Console.WriteLine("Không có dữ liệu đăng nhập.");
            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (SessionStudy sessionStudy in sessionStudies)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["SessionId"].Value = sessionStudy.SessionId;
                    row.Cells["MemberId"].Value = sessionStudy.MemberId;
                    row.Cells["CheckInTIme"].Value = sessionStudy.CheckInTime;
                }
            }
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idMember = textBox1.Text;
            sessionStudyBUS.CheckInTime(int.Parse(idMember));
            loadTable();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panelClock.Invalidate();
        }

        private void panelClock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int width = panelClock.Width;
            int height = panelClock.Height;
            int radius = Math.Min(width, height) / 2 - 10;
            Point center = new Point(width / 2, height / 2);

            // Vẽ viền đồng hồ
            g.DrawEllipse(Pens.Black, center.X - radius, center.Y - radius, radius * 2, radius * 2);

            // Vẽ các số (1 đến 12)
            for (int i = 1; i <= 12; i++)
            {
                double angle = Math.PI / 6 * (i - 3);
                int x = (int)(center.X + Math.Cos(angle) * (radius - 25));
                int y = (int)(center.Y + Math.Sin(angle) * (radius - 25));
                string num = i.ToString();
                SizeF size = g.MeasureString(num, this.Font);
                g.DrawString(num, this.Font, Brushes.Black, x - size.Width / 2, y - size.Height / 2);
            }

            // Lấy thời gian hiện tại
            DateTime now = DateTime.Now;
            float hour = now.Hour % 12 + now.Minute / 60f;
            float minute = now.Minute + now.Second / 60f;
            float second = now.Second;

            // Vẽ kim giờ
            DrawHand(g, center, hour * 30 - 90, radius * 0.5f, 6, Color.Black);

            // Vẽ kim phút
            DrawHand(g, center, minute * 6 - 90, radius * 0.7f, 4, Color.Blue);

            // Vẽ kim giây
            DrawHand(g, center, second * 6 - 90, radius * 0.9f, 2, Color.Red);
        }


        private void DrawHand(Graphics g, Point center, float angleDegrees, float length, float thickness, Color color)
        {
            double angleRadians = Math.PI * angleDegrees / 180.0;
            float x = center.X + (float)(length * Math.Cos(angleRadians));
            float y = center.Y + (float)(length * Math.Sin(angleRadians));
            using (Pen pen = new Pen(color, thickness))
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(pen, center.X, center.Y, x, y);
            }
        }



    }
}
