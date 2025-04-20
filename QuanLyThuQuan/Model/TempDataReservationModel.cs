using System;

namespace QuanLyThuQuan.Model
{
    internal class TempDataReservationModel
    {
        public int reservationID { get; set; }
        public int memberID { get; set; }
        public DateTime reservationDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public ReservationStatus status { get; set; }

        public TempDataReservationModel()
        {

        }

        public TempDataReservationModel(int reservationID, int memberID, DateTime reservationDate, DateTime startTime, DateTime endTime, ReservationStatus status)
        {
            this.reservationID = reservationID;
            this.reservationDate = reservationDate;
            this.memberID = memberID;
            this.reservationDate = reservationDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.status = status;
        }
    }
}
