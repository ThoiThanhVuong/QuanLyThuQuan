﻿using QuanLyThuQuan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.GUI.ProductItem
{
    
    public partial class DeleteBookConditios : Form
    {
        BookBUS bookBus = new BookBUS();
        public DeleteBookConditios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookBus.SetBookInactiveByTitleAndYearRange(textBox1.Text , dateTimePicker1.Value.Year , dateTimePicker2.Value.Year);
        }
    }
}
