using MySql.Data.MySqlClient;
using ThuQuanWebForm.AppConfig;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace ThuQuanWebForm.DAO
{
    public class MemberDAO
    {
        private ConnectDB db;
        

        public MemberDAO()
        {
            try
            {
                // Initialize ConnectDB first
                db = new ConnectDB();

                // Test the database connection to ensure it's working
                db.OpenConnection();
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                // Log the exception details
                System.Diagnostics.Debug.WriteLine($"Error initializing MemberDAO: {ex.Message}");
                // Don't use return in constructor, throw the exception instead
                throw new InvalidOperationException("Failed to initialize database connection", ex);
            }
        }

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

        public MemberModel AuthenticateUser(string username, string password)
        {
            MemberModel member = null;

            try
            {
                // Check if db is initialized
                if (db == null)
                {
                    throw new InvalidOperationException("Database connection is not initialized");
                }

                // Ensure connection is open
                if (db.Connection == null || db.Connection.State != ConnectionState.Open)
                {
                    db.OpenConnection();
                }

                // Modified query to only check username and status, we'll verify password in C# code
                string query = "SELECT * FROM Member WHERE Username = @Username AND Status = @Status";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Status", ActivityStatus.Active.ToString());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Get stored password from database
                            string storedPassword = reader.GetString("Password");

                            // Perform strict case-sensitive string comparison
                            if (string.Equals(password, storedPassword, StringComparison.Ordinal))
                            {
                                member = new MemberModel(
                                    reader.GetInt32("MemberID"),
                                    reader.GetString("FullName"),
                                    reader.GetString("Email"),
                                    reader.GetString("PhoneNumber"),
                                    reader.GetString("Username"),
                                    storedPassword,
                                    reader.GetDateTime("RegistrationDate"),
                                    (UserType)Enum.Parse(typeof(UserType), reader.GetString("UserType")),
                                    (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("Status"))
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error authenticating user: {ex.Message}");
                throw;
            }
            finally
            {
                // Always close the connection in finally block
                if (db != null && db.Connection != null && db.Connection.State == ConnectionState.Open)
                {
                    db.CloseConnection();
                }
            }

            return member;
        }

        public MemberModel Login(string username, string password)
        {
            return AuthenticateUser(username, password);
        }

        public MemberModel GetMemberByEmailOrPhone(string identifier)
        {
            MemberModel member = null;
            db.OpenConnection();
            string query = "SELECT * FROM Member WHERE Email = @Identifier OR PhoneNumber = @Identifier";

            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Identifier", identifier);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    member = new MemberModel(
                        reader.GetInt32("MemberID"),
                        reader.GetString("FullName"),
                        reader.GetString("Email"),
                        reader.GetString("PhoneNumber"),
                        reader.GetString("Username"),
                        reader.GetString("Password"),
                        reader.GetDateTime("RegistrationDate"),
                        (UserType)Enum.Parse(typeof(UserType), reader.GetString("UserType")),
                        (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("Status"))
                    );
                }

                reader.Close();
            }

            db.CloseConnection();
            return member;
        }

        public bool UpdatePassword(int memberId, string newPassword)
        {
            db.OpenConnection();
            string query = "UPDATE Member SET Password = @Password WHERE MemberID = @MemberID";

            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@Password", newPassword);

                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }
    }
}
