
using OfficeOpenXml;
using QuanLyThuQuan.GUI;
using System;

using System.Windows.Forms;

namespace QuanLyThuQuan
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.Run(new Login());

        }
    }
}
