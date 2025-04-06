using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
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
    }
}
