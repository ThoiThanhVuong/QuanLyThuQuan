using MySql.Data.MySqlClient;
using ThuQuanWebForm.AppConfig;
using ThuQuanWebForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuQuanWebForm.DAO
{
    class RuleDAO
    {
        private ConnectDB db = new ConnectDB();
        public List<RuleModel> GetAllRules()
        {
            List<RuleModel> rules = new List<RuleModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Rules";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rules.Add(new RuleModel(
                    reader.GetInt32("RuleID"),
                    reader.GetString("RuleTitle"),
                    reader.GetString("RuleDescription"),
                    reader.GetString("Penalty"),
                    reader.GetDateTime("EffectiveDate"),
                    (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("Status"))
                ));
            }
            reader.Close();
            db.CloseConnection();
            return rules;
        }


        public bool AddRule(RuleModel rule)
        {
            db.OpenConnection();
            string query = "INSERT INTO Rules (RuleTitle, RuleDescription, Penalty, EffectiveDate, Status)" +
                " VALUES (@RuleTitle, @RuleDescription, @Penalty, @EffectiveDate, @Status)";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@RuleTitle", rule.RuleTitle);
                cmd.Parameters.AddWithValue("@RuleDescription", rule.RuleDescription);
                cmd.Parameters.AddWithValue("@Penalty", rule.Penalty);
                cmd.Parameters.AddWithValue("@EffectiveDate", rule.EffectiveDate);
                cmd.Parameters.AddWithValue("@Status", rule.RuleStatus.ToString());
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }

        public bool UpdateRule(RuleModel rule)
        {
            db.OpenConnection();
            string query = "UPDATE Rules SET RuleTitle = @RuleTitle, RuleDescription = @RuleDescription, Penalty = @Penalty, EffectiveDate = @EffectiveDate, Status = @Status WHERE RuleID = @RuleID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@RuleID", rule.RuleID);
                cmd.Parameters.AddWithValue("@RuleTitle", rule.RuleTitle);
                cmd.Parameters.AddWithValue("@RuleDescription", rule.RuleDescription);
                cmd.Parameters.AddWithValue("@Penalty", rule.Penalty);
                cmd.Parameters.AddWithValue("@EffectiveDate", rule.EffectiveDate);
                cmd.Parameters.AddWithValue("@Status", rule.RuleStatus.ToString());
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
            ;
        }

        public bool DeleteRule(int ruleID)
        {
            db.OpenConnection();

            // Sửa câu lệnh SQL để cập nhật status thành Inactive thay vì xóa
            string query = "UPDATE Rules SET Status = @Status WHERE RuleID = @RuleID";

            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@RuleID", ruleID);
                cmd.Parameters.AddWithValue("@Status", "Inactive"); // Đặt giá trị status thành Inactive

                // Kiểm tra nếu có dòng nào bị ảnh hưởng (nếu có thì trả về true)
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }


        public bool RuleExistsById(int ruleID)
        {
            db.OpenConnection();
            string query = "SELECT * FROM Rules WHERE RuleID = @RuleID";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@RuleID", ruleID);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool exists = reader.Read(); // Returns true if a record is found, false otherwise
                reader.Close();
                db.CloseConnection();
                return exists;
            }
        }

        public int GetMaxRuleId()
        {
            db.OpenConnection();
            string query = "SELECT MAX(RuleId) FROM Rules";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            int maxRuleID = Convert.ToInt32(cmd.ExecuteScalar());
            maxRuleID++;
            db.CloseConnection();
            return maxRuleID;
        }

        public List<RuleModel> GetActiveRules()
        {
            List<RuleModel> rules = new List<RuleModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Rules WHERE Status = @Status";
            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Status", ActivityStatus.Active.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rules.Add(new RuleModel(
                        reader.GetInt32("RuleID"),
                        reader.GetString("RuleTitle"),
                        reader.GetString("RuleDescription"),
                        reader.GetString("Penalty"),
                        reader.GetDateTime("EffectiveDate"),
                        (ActivityStatus)Enum.Parse(typeof(ActivityStatus), reader.GetString("Status"))
                    ));
                }
                reader.Close();
            }
            db.CloseConnection();
            return rules;

        }

    }
}