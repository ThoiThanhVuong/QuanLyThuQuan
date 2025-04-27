using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuQuan.Services
{
    internal class NotificationServices
    {
        private static NotificationServices _INSTANCE = new NotificationServices();
        private NotificationServices() { }
        public static NotificationServices GetInstance()
        {
            return _INSTANCE;
        }
        public void ShowError(string message, string alertName)
        {
            MessageBox.Show(message, alertName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string message, string alertName)
        {
            MessageBox.Show(message, alertName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowSuccess(string message, string alertName)
        {
            MessageBox.Show(message, alertName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Confirm với nút OK (phải) và Cancel (trái)
        public DialogResult ShowConfirm(string message, string alertName)
        {
            return MessageBox.Show(message, alertName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
