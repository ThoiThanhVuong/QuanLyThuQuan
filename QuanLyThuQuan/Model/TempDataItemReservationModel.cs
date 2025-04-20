namespace QuanLyThuQuan.Model
{
    internal class TempDataItemReservationModel
    {
        public int reservationID { get; set; }
        public int itemID { get; set; }
        public int? bookID { get; set; }
        public int? deviceID { get; set; }
        public int amount { get; set; }

        public TempDataItemReservationModel()
        {

        }

        public TempDataItemReservationModel(int itemID, int reservationID, int? bookID, int? deviceID, int amount)
        {
            this.itemID = itemID;
            this.reservationID = reservationID;
            this.bookID = bookID;
            this.deviceID = deviceID;
            this.amount = amount;
        }

    }
}
