using ThuQuanWebForm.DAO;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;

namespace ThuQuanWebForm.BUS
{
    class LoginHistoryBUS
    {
        private LoginHistoryDAO loginHistoryDAO = new LoginHistoryDAO();

        public List<LoginHistoryModel> GetAllLoginHistory()
        {
            return loginHistoryDAO.GetAllLoginHistory();
        }

        public bool RecordLogin(int memberId)
        {
            try
            {
                return loginHistoryDAO.RecordLogin(memberId);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}