using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    public class ReservationItemModel
    {
        public int ItemID { get; set; }
        public int ReservationID { get; set; }
        public int? BookID { get; set; }
        public int? DeviceID { get; set; }
        public int Amount { get; set; }
    }
}
