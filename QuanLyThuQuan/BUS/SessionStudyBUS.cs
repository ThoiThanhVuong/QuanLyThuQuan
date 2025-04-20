using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class SessionStudyBUS
    {
        public List<SessionStudy> GetSessionStudies()
        {
            SessionStudyDAO sessionStudyDAO = new SessionStudyDAO();
            return sessionStudyDAO.GetSessionStudies();
        }
        public bool CheckInTime(int idMember)
        {
            SessionStudyDAO sessionStudyDAO = new SessionStudyDAO();
            return sessionStudyDAO.addSessionStudy(idMember);
        }
    }
}
