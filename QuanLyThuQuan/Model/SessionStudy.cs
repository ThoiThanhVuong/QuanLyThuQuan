using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class SessionStudy
    {
        public int SessionId { get; set; }
        public int MemberId { get; set; }
        public DateTime CheckInTime { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }

        public SessionStudy() { }

        public SessionStudy(int sessionId, int memberId, DateTime checkInTime)
        {
            SessionId = sessionId;
            MemberId = memberId;
            CheckInTime = checkInTime;
        }

        public SessionStudy(int sessionId, int memberId, DateTime checkInTime, string fullName, string userName)
        {
            SessionId = sessionId;
            MemberId = memberId;
            CheckInTime = checkInTime;
            FullName = fullName;
            UserName = userName;
        }
    }
}
