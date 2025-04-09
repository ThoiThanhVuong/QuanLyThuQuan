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
        Return,
        Reserve
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

}
