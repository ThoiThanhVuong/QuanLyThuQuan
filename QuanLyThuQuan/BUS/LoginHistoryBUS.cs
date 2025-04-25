using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

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

        public List<LoginCountModel> GetAllLoginCounts()
        {
            return loginHistoryDAO.GetAllLoginCounts();
        }

        public List<LoginCountModel> GetLoginCountByMemberID(int memberID)
        {
            return loginHistoryDAO.GetLoginCountByMemberID(memberID);
        }

        public List<LoginCountModel> GetLoginCountByDate(DateTime from, DateTime to)
        {
            return loginHistoryDAO.GetLoginCountByDate(from, to);
        }

        public List<LoginCountModel> GetLoginCountByMemberAndDate(int memberID, DateTime from, DateTime to)
        {
            return loginHistoryDAO.GetLoginCountByMemberAndDate(memberID, from, to);
        }
    }
}