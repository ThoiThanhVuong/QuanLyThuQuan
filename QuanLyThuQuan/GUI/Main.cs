using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI
{
    public partial class FormMain: Form
    {
        FormBook pnBook;
        FormDashBoard pnDashBoard;
        FormDevice pnDevice;
        FormRule pnRule;
        FormTransaction pnTransaction;
        FormViolation pnViolation;
        FormReview pnReview;
        FormStatistic pnStatistic;
        Login formLogin;
        public FormMain()
        {
            InitializeComponent();
            ShowDefaultForm();
        }
        // Xét form mặc định
        private void ShowDefaultForm()
        {
            if (pnDashBoard == null)
            {
                pnDashBoard = new FormDashBoard();
                pnDashBoard.FormClosed += PnDashBoard_FormClosed;
                pnDashBoard.MdiParent = this;
                pnDashBoard.Dock = DockStyle.Fill;
                pnDashBoard.Show();
            }
            else
            {
                pnDashBoard.Activate();
            }
        }
        // chuyển động của nút product
        bool productExpand = false;
        private void ProductTransition_Tick(object sender, EventArgs e)
        {
            if(productExpand == false)
            {
                ProductContainer.Height += 10;
                if(ProductContainer.Height >= 150)
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
            if(sidebarExpand )
            {
                SideBar.Width -= 13;
                if(SideBar.Width <=70)
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
            ShowDefaultForm();
        }

        private void PnDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnDashBoard = null;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if(pnBook == null)
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
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            if(pnDevice == null)
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
        }

        private void btnRule_Click(object sender, EventArgs e)
        {
            if(pnRule == null)
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
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if(pnTransaction == null)
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
            if(pnViolation == null)
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
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if(pnReview == null)
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
        }

        private void PnReview_FormClosed(object sender, FormClosedEventArgs e)
        {
            pnReview = null;
        }

        private void btnCloseProgram_Click(object sender, EventArgs e)
        {   
           
            this.Close();
        }

        private  async void btnMinimize_Click(object sender, EventArgs e)
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
            if(pnStatistic == null)
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
