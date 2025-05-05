using ThuQuanWebForm.DAO;
using ThuQuanWebForm.Model;
using System.Collections.Generic;

namespace ThuQuanWebForm.BUS
{
    class ViolationBUS
    {
        ViolationDAO violationDAO = new ViolationDAO();

        public List<ViolationModel> GetViolations()
        {
            return violationDAO.GetViolations();
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
    }
}
