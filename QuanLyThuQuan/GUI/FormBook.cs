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
    public partial class FormBook: Form
    {
        public FormBook()
        {
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            // thử nghiệm
            List<string> danhSachSach = new List<string>() { "Sách 1", "Sách 2", "Sách 3" ,"Sách 4","Sách 5"};

            foreach (var tenSach in danhSachSach)
            {
                
                BookItemControl bookItem = new BookItemControl();

                
                ListBook.Controls.Add(bookItem);
            }
        }
    }
}
