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
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SideBar.Width);
            if (SideBar.Width == 250)
            {
                Console.WriteLine("nhánh if");
                SideBar.Width = 40;
            }
            else
            {
                Console.WriteLine("nhánh else");
                SideBar.Width = 250;
            }
            
        }
    }
}
