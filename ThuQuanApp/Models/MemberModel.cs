namespace ThuQuanApp.Models
{
    public class MemberModel
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required DateTime RegistrationDate { get; set; }
        public required string UserType { get; set; }
        public required string Status { get; set; }
    }
}
