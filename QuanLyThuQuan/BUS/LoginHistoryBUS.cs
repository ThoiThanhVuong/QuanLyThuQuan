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

    }
}