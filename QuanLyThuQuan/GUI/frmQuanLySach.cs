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
    public partial class frmQuanLySach: Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void btnCloseQLSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
