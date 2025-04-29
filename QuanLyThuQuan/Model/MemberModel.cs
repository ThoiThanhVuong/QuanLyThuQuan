using System;

namespace QuanLyThuQuan.Model
{

    public class MemberModel
    {
        public int MemberID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public UserType UserType { get; set; }
        public ActivityStatus MemberStatus { get; set; }
        public MemberModel()
        {

        }

        public MemberModel(int memberID, string fullName, string email, string phoneNumber)
        {
            MemberID = memberID;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public MemberModel(int memberID, string fullName, string email, string phoneNumber, string username, string password, DateTime registrationDate, UserType userType, ActivityStatus memberStatus)
        {
            MemberID = memberID;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Username = username;
            Password = password;
            RegistrationDate = registrationDate;
            UserType = userType;
            MemberStatus = memberStatus;
        }

        public MemberModel(MemberModel memberModel)
        {
            this.MemberID = memberModel.MemberID;
            this.FullName = memberModel.FullName;
            this.Email = memberModel.Email;
            this.PhoneNumber = memberModel.PhoneNumber;
            this.Username = memberModel.Username;
            this.Password = memberModel.Password;
            this.RegistrationDate = memberModel.RegistrationDate;
            this.UserType = memberModel.UserType;
            this.MemberStatus = memberModel.MemberStatus;
        }
        public override string ToString()
        {
            return $"MemberID:{MemberID},Fullname:{FullName},Email:{Email},PhoneNumber:{PhoneNumber}";
        }
    }
}
