using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{ 
 
    class MemberModel
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
    }
}
