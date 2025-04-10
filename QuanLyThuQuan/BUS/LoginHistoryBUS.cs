using System;
using System.Collections.Generic;
using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;

namespace QuanLyThuQuan.BUS
{
    class LoginHistoryBUS
    {
        private LoginHistoryDAO loginHistoryDAO = new LoginHistoryDAO();

        public List<LoginHistoryModel> GetAllLoginHistory()
        {
            return loginHistoryDAO.GetAllLoginHistory();
        }

        public List<LoginHistoryModel> GetLoginHistoryByMemberID(int memberID)
        {
            return loginHistoryDAO.GetLoginHistoryByMemberID(memberID);
        }

        public LoginHistoryModel GetLoginHistoryByID(int loginID)
        {
            return loginHistoryDAO.GetLoginHistoryByID(loginID);
        }

        public bool AddLoginHistory(LoginHistoryModel loginHistory)
        {
            return loginHistoryDAO.AddLoginHistory(loginHistory);
        }

        public bool UpdateLoginHistory(LoginHistoryModel loginHistory)
        {
            return loginHistoryDAO.UpdateLoginHistory(loginHistory);
        }

        public bool DeleteLoginHistory(int loginID)
        {
            return loginHistoryDAO.DeleteLoginHistory(loginID);
        }

        public bool UpdateLogoutTime(int loginID, DateTime logoutTime)
        {
            return loginHistoryDAO.UpdateLogoutTime(loginID, logoutTime);
        }

        public bool RecordLogin(int memberID, bool success)
        {
            LoginHistoryModel loginRecord = new LoginHistoryModel(
                0, // LoginID will be assigned by the database
                memberID,
                DateTime.Now,
                null, // LogoutTime will be updated later on logout
                success ? LoginStatus.Success : LoginStatus.Failed
            );

            return loginHistoryDAO.AddLoginHistory(loginRecord);
        }

        public bool RecordLogout(int loginID)
        {
            return loginHistoryDAO.UpdateLogoutTime(loginID, DateTime.Now);
        }
    }
}