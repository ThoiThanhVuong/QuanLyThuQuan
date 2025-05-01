namespace QuanLyThuQuan.Model
{
    public enum ProductStatus
    {
        Available,
        OutOf,
        Unavailable
    }
    public enum UserType
    {
        Admin,
        User,
        Librarian
    }
    public enum ActivityStatus
    {
        Active,
        Inactive
    }
    public enum TransactionType
    {
        Borrow,
        Return
       
    }

    public enum TransactionStatus
    {
        Active,
        Completed,
        Overdue
    }
    public enum PaidStatus
    {
        Unpaid,
        Paid
    }
    public enum LoginStatus
    {
        Success,
        Failed
    }


    public enum ReservationStatus
    {
        Confirmed,
        Pending,
        Cancelled
    }
    public enum TransactionItemStatus
    {
        Borrowed,
        Returned
    }
 
}
