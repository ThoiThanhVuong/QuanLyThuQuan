using QuanLyThuQuan.Model;
using System.Collections.Generic;

namespace QuanLyThuQuan.Services
{
    internal class SessionManagerService
    {
        private static SessionManagerService _instance;
        private MemberModel _loggedMember;
        private HashSet<string> _exceptModules;

        private SessionManagerService()
        {
            _exceptModules = new HashSet<string>();
        }

        public static SessionManagerService GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new SessionManagerService();
                return _instance;
            }
        }

        public void SetLoggedMember(MemberModel member)
        {
            _loggedMember = member;
            LoadPermissions();
        }

        public void Logout()
        {
            _loggedMember = null;
            _exceptModules.Clear();
        }

        public bool HasModuleAccess(string moduleName)
        {
            return _exceptModules.Contains(moduleName);
        }

        private void LoadPermissions()
        {
            _exceptModules.Clear();

            if (_loggedMember == null) return;
            if (_loggedMember.UserType.Equals(UserType.Admin))
                _exceptModules.Add("None");
            else if (_loggedMember.UserType.Equals(UserType.Librarian))
                _exceptModules.Add("RemoveMember");
        }

        public MemberModel Currmember()
        {
            return _loggedMember != null ? new MemberModel(_loggedMember) : null;
        }

        public int NumAllowedModules()
        {
            return _exceptModules.Count;
        }

        public int MemberLoginId()
        {
            return _loggedMember.MemberID;
        }

        public UserType EmployeeRoleId()
        {
            return _loggedMember.UserType;
        }

        public bool CanRemoveMember()
        {
            foreach (string moduleName in _exceptModules)
                if (!moduleName.ToLower().Equals("removemember"))
                    return true;
            return false;
        }

    }
}
