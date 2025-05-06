using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    class MemberBUS
    {
        MemberDAO memberDAO = new MemberDAO();

        public List<MemberModel> GetAllMembers()
        {
            return memberDAO.GetActiveMembers();
        }
        public bool AddMember(MemberModel member)
        {
            return memberDAO.AddMember(member);
        }
        public bool UpdateMember(MemberModel member)
        {
            return memberDAO.UpdateMember(member);
        }
        public bool DeleteMember(int memberID)
        {
            return memberDAO.DeleteMember(memberID);
        }
        public int GetMaxMemberID()
        {
            return memberDAO.GetMaxMemberId();
        }

        public bool GetMemberById(int memberID)
        {
            return memberDAO.MemberExistsById(memberID);
        }

        public List<MemberModel> GetActiveMembers()
        {
            return memberDAO.GetActiveMembers();
        }

        public int DeleteMembersByDateRangeAndType(DateTime startDate, DateTime endDate, string userType)
        {
            return memberDAO.DeleteMembersByDateRangeAndType(startDate, endDate, userType);
        }




    }
}
