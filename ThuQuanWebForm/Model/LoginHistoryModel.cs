using System;

namespace ThuQuanWebForm.Model
{
    class LoginHistoryModel
    {
        public int LoginID { get; set; }
        public int MemberID { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public LoginStatus Status { get; set; }

        // Navigation Property
        public MemberModel Member { get; set; }

        public LoginHistoryModel()
        {

        }

        public LoginHistoryModel(int loginID, int memberID, DateTime loginTime, DateTime? logoutTime, LoginStatus status)
        {
            LoginID = loginID;
            MemberID = memberID;
            LoginTime = loginTime;
            LogoutTime = logoutTime;
            Status = status;
        }

        public LoginHistoryModel(int loginID, int memberID, DateTime loginTime, DateTime? logoutTime, LoginStatus status, MemberModel member) : this(loginID, memberID, loginTime, logoutTime, status)
        {
            Member = member;
        }
    }
}
