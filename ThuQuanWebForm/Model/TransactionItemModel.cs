namespace ThuQuanWebForm.Model
{
    public class TransactionItemModel
    {
        public int ItemID { get; set; }
        public int TransactionID { get; set; }
        public int? BookID { get; set; }
        public int? DeviceID { get; set; }
        public int Amount { get; set; }
        public TransactionItemStatus Status { get; set; }
        // Nếu muốn lấy thông tin trực tiếp
        public TransactionModel Transaction { get; set; }
        public BookModel Book { get; set; }
        public DeviceModel Device { get; set; }

        public TransactionItemModel()
        {

        }

        public TransactionItemModel(int itemID, int transactionID, int? bookID, int? deviceID, int amount, TransactionItemStatus status)
        {
            ItemID = itemID;
            TransactionID = transactionID;
            BookID = bookID;
            DeviceID = deviceID;
            Amount = amount;
            Status = status;
        }

        public TransactionItemModel(int itemID, int transactionID, int? bookID, int? deviceID, int amount, TransactionItemStatus status, TransactionModel transaction, BookModel book, DeviceModel device) : this(itemID, transactionID, bookID, deviceID, amount, status)
        {
            Transaction = transaction;
            Book = book;
            Device = device;
        }
    }
}
