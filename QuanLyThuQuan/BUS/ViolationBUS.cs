using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class ViolationBUS
    {
        ViolationDAO violationDAO = new ViolationDAO();

        public List<ViolationModel> GetViolations()
        {
            return violationDAO.GetViolations();
        }
        public ViolationModel GetViolationByID(int ID)
        {
            return violationDAO.GetViolationByID(ID);
        }
        public bool AddViolation(ViolationModel violation)
        {
            return violationDAO.AddViolation(violation);
        }

        public bool UpdateViolation(ViolationModel violation)
        {
            return violationDAO.UpdateViolation(violation);
        }

        public bool DeleteViolation(int violationID)
        {
            return violationDAO.DeleteViolation(violationID);
        }

        public int maxViolationID()
        {
            return violationDAO.MaxViolationID();
        }
        public int checkCountViolationByID(int ID)
        {
            return violationDAO.checkCountViolationByID(ID);
        }
        public bool MarkViolationAsHandled(int violationID)
        {
            return violationDAO.MarkViolationAsHandled(violationID);
        }
        public List<ViolationModel> SearchViolationByMemberID(string keyword)
        {
            return violationDAO.SearchViolationByMemberID(keyword);
        }
    }
}
