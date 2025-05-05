using ThuQuanWebForm.DAO;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuQuanWebForm.BUS
{
    class SessionStudyBUS
    {
        public List<SessionStudy> GetAllSessionStudies()
        {
            SessionStudyDAO sessionStudyDAO = new SessionStudyDAO();
            return sessionStudyDAO.GetAllSessionStudies();
        }

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
