using ThuQuanWebForm.DAO;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuQuanWebForm.BUS
{
    public class MemberBUS
    {
        private readonly MemberDAO _memberDAO;

        public MemberBUS()
        {
            try
            {
                _memberDAO = new MemberDAO();
            }
            catch (NullReferenceException ex)
            {
                // Log the error or handle it appropriately
                throw new Exception("Failed to initialize MemberDAO due to null reference. Please check database connection.", ex);
            }
            catch (InvalidOperationException ex)
            {
                // Specifically handle database connection errors
                throw new Exception("Database connection failed. Please check your connection settings.", ex);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                throw new Exception("An unexpected error occurred while initializing MemberDAO.", ex);
            }
        }

        public MemberModel AuthenticateUser(string username, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    return null;
                }

                return _memberDAO.AuthenticateUser(username, password);
            }
            catch (InvalidOperationException ex)
            {
                // Log the database connection error
                System.Diagnostics.Debug.WriteLine($"Database connection error in AuthenticateUser: {ex.Message}");
                throw new Exception("Cannot connect to the database. Please try again later.", ex);
            }
            catch (Exception ex)
            {
                // Log any other errors
                System.Diagnostics.Debug.WriteLine($"Error in AuthenticateUser method: {ex.Message}");
                throw;
            }
        }

        public List<MemberModel> GetAllMembers()
        {
            return _memberDAO.GetActiveMembers();
        }
        public bool AddMember(MemberModel member)
        {
            return _memberDAO.AddMember(member);
        }
        public bool UpdateMember(MemberModel member)
        {
            return _memberDAO.UpdateMember(member);
        }
        public bool DeleteMember(int memberID)
        {
            return _memberDAO.DeleteMember(memberID);
        }
        public int GetMaxMemberID()
        {
            return _memberDAO.GetMaxMemberId();
        }

        public bool GetMemberById(int memberID)
        {
            return _memberDAO.MemberExistsById(memberID);
        }

        public List<MemberModel> GetActiveMembers()
        {
            return _memberDAO.GetActiveMembers();
        }


        // Added method to find member by email or phone
        public MemberModel GetMemberByEmailOrPhone(string identifier)
        {
            return _memberDAO.GetMemberByEmailOrPhone(identifier);
        }

        // Added method to update password
        public bool UpdatePassword(int memberId, string newPassword)
        {
            return _memberDAO.UpdatePassword(memberId, newPassword);
        }

        public MemberModel Login(string username, string password)
        {
            // Convert username to lowercase to make it case-insensitive
            if (username != null)
            {
                username = username.ToLower();
            }

            try
            {
                return _memberDAO.Login(username, password);
            }
            catch (NullReferenceException ex)
            {
                // Log the exception
                Console.WriteLine($"Error in Login method: {ex.Message}");
                return null;
            }
        }
    }
}
