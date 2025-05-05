using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Data;


namespace QuanLyThuQuan.DAO
{
    class MemberDAO
    {
        private ConnectDB db = new ConnectDB();
        public List<MemberModel> GetAllMembers()
        {
            List<MemberModel> members = new List<MemberModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Member";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                members.Add(new MemberModel(
                    reader.GetInt32("MemberID"),
                    reader.GetString("FullName"),
                    reader.GetString("Email"),
                    reader.GetString("PhoneNumber"),
                    reader.GetString("Username"),
                    reader.GetString("Password"),
                    reader.GetDateTime("RegistrationDate"),
                    (UserType)Enum.Parse(typeof(UserType), reader.GetString("UserType")),
                    (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("Status"))
                ));
            }
            reader.Close();
            db.CloseConnection();
            return members;
        }

        public bool AddMember(MemberModel member)
        {
            db.OpenConnection();
            string query = @"INSERT INTO Member (FullName, Email, PhoneNumber, Username, Password, RegistrationDate, UserType, Status) 
                         VALUES (@FullName, @Email, @PhoneNumber, @Username, @Password, @RegistrationDate, @UserType, @Status)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@FullName", member.FullName);
                cmd.Parameters.AddWithValue("@Email", member.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
                cmd.Parameters.AddWithValue("@Username", member.Username);
                cmd.Parameters.AddWithValue("@Password", member.Password);
                cmd.Parameters.AddWithValue("@RegistrationDate", member.RegistrationDate);
                cmd.Parameters.AddWithValue("@UserType", member.UserType.ToString());
                cmd.Parameters.AddWithValue("@Status", member.MemberStatus.ToString());

                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool UpdateMember(MemberModel member)
        {
            db.OpenConnection();
            string query = @"UPDATE Member 
                         SET FullName = @FullName, Email = @Email, PhoneNumber = @PhoneNumber, 
                             Username = @Username, Password = @Password, 
                             RegistrationDate = @RegistrationDate, UserType = @UserType, Status = @Status 
                         WHERE MemberID = @MemberID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberID", member.MemberID);
                cmd.Parameters.AddWithValue("@FullName", member.FullName);
                cmd.Parameters.AddWithValue("@Email", member.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", member.PhoneNumber);
                cmd.Parameters.AddWithValue("@Username", member.Username);
                cmd.Parameters.AddWithValue("@Password", member.Password);
                cmd.Parameters.AddWithValue("@RegistrationDate", member.RegistrationDate);
                cmd.Parameters.AddWithValue("@UserType", member.UserType.ToString());
                cmd.Parameters.AddWithValue("@Status", member.MemberStatus.ToString());

                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool DeleteMember(int memberId)
        {
            db.OpenConnection();
            string query = "UPDATE Member SET Status = @Status WHERE MemberID = @MemberID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@Status", ActivityStatus.Inactive.ToString());

                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool MemberExistsById(int memberId)
        {
            db.OpenConnection();
            string query = "SELECT * FROM Member WHERE MemberID = @MemberID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool exists = reader.Read();
                reader.Close();
                db.CloseConnection();
                return exists;
            }
        }

        public int GetMaxMemberId()
        {
            db.OpenConnection();
            string query = "SELECT MAX(MemberID) FROM Member";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            object result = cmd.ExecuteScalar();
            int maxId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;
            db.CloseConnection();
            return maxId;
        }

        public List<MemberModel> GetActiveMembers()
        {
            List<MemberModel> members = new List<MemberModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Member WHERE Status = @Status";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Status", ActivityStatus.Active.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new MemberModel(
                        reader.GetInt32("MemberID"),
                        reader.GetString("FullName"),
                        reader.GetString("Email"),
                        reader.GetString("PhoneNumber"),
                        reader.GetString("Username"),
                        reader.GetString("Password"),
                        reader.GetDateTime("RegistrationDate"),
                        (UserType)Enum.Parse(typeof(UserType), reader.GetString("UserType")),
                        (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("Status"))
                    ));
                }
                reader.Close();
            }
            db.CloseConnection();
            return members;
        }
    

    public int DeleteMembersByDateRangeAndType(DateTime startDate, DateTime endDate, string userType)
        {
            int rowsAffected = 0;
            try
            {
                db.OpenConnection();
                string query = @"
                UPDATE Member
                SET Status = 'Inactive'
                WHERE RegistrationDate BETWEEN @StartDate AND @EndDate
                  AND UserType = @UserType
                  AND Status = 'Active'";

                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@UserType", userType);

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return rowsAffected;
        }
    }

}
