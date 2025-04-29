using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    public class ReservationModel
    {
        public int ReservationID { get; set; }
        public int MemberID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ReservationStatus Status { get; set; } 
        public List<ReservationItemModel> Items { get; set; } = new List<ReservationItemModel>();
    }
}
