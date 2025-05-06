using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class MemberPenaltyModel
    {
        public int PenaltyID { get; set; }
        public int MemberID { get; set; }
        public int ViolationID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public MemberPenaltyModel()
        {
            
        }

        public MemberPenaltyModel(int penaltyID, int memberID, int violationID, DateTime startDate, DateTime? endDate, string description)
        {
            PenaltyID = penaltyID;
            MemberID = memberID;
            ViolationID = violationID;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
    }
}
