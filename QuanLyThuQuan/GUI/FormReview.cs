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
    public partial class FormReview: Form
    {
        public FormReview()
        {
            InitializeComponent();
        }

        private void FormReview_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
