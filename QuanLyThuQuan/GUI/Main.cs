using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormMain : Form
    {
     
        Login formLogin;
        private Form currentForm = null;
        public FormMain()
        {
            InitializeComponent();
            ShowDefaultForm();
        }
        // Xét form mặc định
        private void ShowDefaultForm()
        {
            ShowFormInPanel(new FormDashBoard());
        }
        public void ShowFormInPanel(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close(); // Đóng form cũ trước khi mở form mới
            }

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(form);
            form.Show();
        }
        // chuyển động của nút product
        bool productExpand = false;
        private void ProductTransition_Tick(object sender, EventArgs e)
        {
            if (productExpand == false)
            {
                ProductContainer.Height += 10;
                if (ProductContainer.Height >= 150)
                {
                    ProductTransition.Stop();
                    productExpand = true;
                }
            }
            else
            {
                ProductContainer.Height -= 10;
                if (ProductContainer.Height <= 50)
                {
                    ProductTransition.Stop();
                    productExpand = false;
                }
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductTransition.Start();
        }
        // chuyển động của sidebar
        bool sidebarExpand = true;
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SideBar.Width -= 13;
                if (SideBar.Width <= 70)
                {
                    sidebarExpand = false;
                    SideBarTransition.Stop();

                    //btnDashBoard.Width = SideBar.Width;
                    //btnRule.Width = SideBar.Width;
                    //btnTransaction.Width = SideBar.Width;
                    //btnReview.Width = SideBar.Width;
                    //ProductContainer.Width = SideBar.Width;
                    //btnViolation.Width = SideBar.Width;

                }
            }
            else
            {
                SideBar.Width += 13;
                if (SideBar.Width >= 240)
                {
                    sidebarExpand = true;
                    SideBarTransition.Stop();
                    btnDashBoard.Width = SideBar.Width;
                    btnRule.Width = SideBar.Width;
                    btnTransaction.Width = SideBar.Width;
                    btnReview.Width = SideBar.Width;
                    ProductContainer.Width = SideBar.Width;
                    btnViolation.Width = SideBar.Width;
                    btnLogout.Width = SideBar.Width;
                }
            }
        }

        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormDashBoard());
        }


        private void btnBook_Click(object sender, EventArgs e)
        {

            ShowFormInPanel(new FormBook(this));


        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormDevice());

        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormRule());

        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormTransaction());
        }

        private void btnViolation_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormViolation());

        }




        private void btnReview_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormReview());

        }


        private void btnCloseProgram_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            //this.Opacity = 1.0;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

            ShowFormInPanel(new FormStatistic());

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                formLogin = new Login();
                formLogin.ShowDialog();
                this.Close();
            }
        }
    }
}
