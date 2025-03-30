using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormMain : Form
    {
        //FormBook pnBook;
        //FormDashBoard pnDashBoard;
        //FormDevice pnDevice;
        //FormRule pnRule;
        //FormTransaction pnTransaction;
        //FormViolation pnViolation;
        //FormReview pnReview;
        //FormStatistic pnStatistic;
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
<<<<<<< HEAD
            ShowFormInPanel(new FormBook(this));
=======
            if (pnBook == null)
            {
                pnBook = new FormBook();
                pnBook.FormClosed += PnBook_FormClosed;
                pnBook.MdiParent = this;
                pnBook.Dock = DockStyle.Fill;
                pnBook.Show();
            }
            else
            {
                pnBook.Activate();
            }
        }

        private void PnBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnBook = null;
>>>>>>> 80d07a07e987b6edf8e8bdcb9413a8344867b74a
        }

      
        private void btnDevice_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ShowFormInPanel(new FormDevice());
=======
            if (pnDevice == null)
            {
                pnDevice = new FormDevice();
                pnDevice.FormClosed += PnDevice_FormClosed;
                pnDevice.MdiParent = this;
                pnDevice.Dock = DockStyle.Fill;
                pnDevice.Show();
            }
            else
            {
                pnDevice.Activate();
            }
        }

        private void PnDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnDevice = null;
>>>>>>> 80d07a07e987b6edf8e8bdcb9413a8344867b74a
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ShowFormInPanel(new FormRule());
=======
            if (pnRule == null)
            {
                pnRule = new FormRule();
                pnRule.FormClosed += PnRule_FormClosed;
                pnRule.MdiParent = this;
                pnRule.Dock = DockStyle.Fill;
                pnRule.Show();
            }
            else
            {
                pnRule.Activate();
            }
        }

        private void PnRule_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnRule = null;
>>>>>>> 80d07a07e987b6edf8e8bdcb9413a8344867b74a
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
           ShowFormInPanel(new FormTransaction());
        }
    
        private void btnViolation_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormViolation());
=======
            if (pnTransaction == null)
            {
                pnTransaction = new FormTransaction();
                pnTransaction.FormClosed += PnTransaction_FormClosed;
                pnTransaction.MdiParent = this;
                pnTransaction.Dock = DockStyle.Fill;
                pnTransaction.Show();

            }
            else
            {
                pnTransaction.Activate();
            }
        }

        private void PnTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnTransaction = null;
        }

        private void btnViolation_Click(object sender, EventArgs e)
        {
            if (pnViolation == null)
            {
                pnViolation = new FormViolation();
                pnViolation.FormClosed += PnViolation_FormClosed;
                pnViolation.MdiParent = this;
                pnViolation.Dock = DockStyle.Fill;
                pnViolation.Show();
            }
            else
            {
                pnViolation.Activate();
            }
        }

        private void PnViolation_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnViolation = null;
>>>>>>> 80d07a07e987b6edf8e8bdcb9413a8344867b74a
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            ShowFormInPanel(new FormReview());
=======
            if (pnReview == null)
            {
                pnReview = new FormReview();
                pnReview.FormClosed += PnReview_FormClosed;
                pnReview.MdiParent = this;
                pnReview.Dock = DockStyle.Fill;
                pnReview.Show();
            }
            else
            {
                pnReview.Activate();
            }
>>>>>>> 80d07a07e987b6edf8e8bdcb9413a8344867b74a
        }


        private void btnCloseProgram_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void btnMinimize_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0.1; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(30);
            }
            this.WindowState = FormWindowState.Minimized;
            this.Opacity = 1.0;
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
<<<<<<< HEAD
            ShowFormInPanel(new FormStatistic());
=======
            if (pnStatistic == null)
            {
                pnStatistic = new FormStatistic();
                pnStatistic.FormClosed += PnStatistic_FormClosed;
                pnStatistic.MdiParent = this;
                pnStatistic.Dock = DockStyle.Fill;
                pnStatistic.Show();
            }
            else
            {
                pnStatistic.Activate();
            }
        }

        private void PnStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnStatistic = null;
>>>>>>> 80d07a07e987b6edf8e8bdcb9413a8344867b74a
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
