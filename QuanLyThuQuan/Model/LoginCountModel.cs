using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class LoginCountModel
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int LoginCount { get; set; }

        public LoginCountModel() { }

        public LoginCountModel(int memberID, string memberName, int loginCount)
        {
            this.MemberID = memberID;
            this.MemberName = memberName;
            this.LoginCount = loginCount;
        }
    }


}
