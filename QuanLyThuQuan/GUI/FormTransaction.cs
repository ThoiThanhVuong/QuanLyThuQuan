﻿using System;
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
    public partial class FormTransaction: Form
    {
        public FormTransaction()
        {
            InitializeComponent();
        }

        private void FormTransaction_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
