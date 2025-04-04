using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.DAO
{
    class DeviceDAO
    {
        private ConnectDB db = new ConnectDB();
        
        public List<DeviceModel> GetAllDevices()
        {
            List<DeviceModel> devices = new List<DeviceModel>();
            db.OpenConnection();
            string query = "SELECT * FROM Devices";
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                devices.Add(new DeviceModel(
                        reader.GetInt32("DeviceID"),
                        reader.GetString("DeviceName"),
                        reader.GetString("DeviceImage"),
                        reader.GetString("DeviceType"),
                        reader.GetInt32("Quantity"),
                        (ProductStatus)Enum.Parse(typeof(ProductStatus),reader.GetString("Status")),
                        reader.GetInt32("fee_per_hour")
                 ));
            }
            reader.Close();
            db.OpenConnection();
            return devices; 
        }
        public bool AddDevice(DeviceModel device)
        {
            db.OpenConnection();
            string query = "INSERT INTO Devices (DeviceName,DeviceImage,DeviceType,Quantity,Status,fee_per_hour)" +
                "VALUES (@DeviceName,@DeviceImage,@DeviceType,@Quantity,@Status,@fee_per_hour)";
            using(MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@DeviceName", device.DeviceName);
                cmd.Parameters.AddWithValue("@DeviceImage", device.DeviceImage);
                cmd.Parameters.AddWithValue("@DeviceType", device.DeviceType);
                cmd.Parameters.AddWithValue("@Quantity", device.DeviceQuantity);
                cmd.Parameters.AddWithValue("@Status", device.DeviceStatus.ToString());
                cmd.Parameters.AddWithValue("@fee_per_hour", device.FeePerHour);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
           
        }
        public bool UpdateDevice(DeviceModel device)
        {
            db.OpenConnection();
            string query=("UPDATE Devices " +
                "SET DeviceName=@DeviceName ,DeviceImage=@DeviceImage,DeviceType=@DeviceType,Quantity=@Quantity,Status=@Status,fee_per_hour=@fee_per_hour" +
                "WHERE DeviceID =@DeviceID");
            using(MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@DeviceID", device.DeviceID);
                cmd.Parameters.AddWithValue("@DeviceName", device.DeviceName);
                cmd.Parameters.AddWithValue("@DeviceImage", device.DeviceImage);
                cmd.Parameters.AddWithValue("@DeviceType", device.DeviceType);
                cmd.Parameters.AddWithValue("@Quantity", device.DeviceQuantity);
                cmd.Parameters.AddWithValue("@Status", device.DeviceStatus.ToString());
                cmd.Parameters.AddWithValue("@fee_per_hour", device.FeePerHour);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
           
        }
        public bool DeleteDevice(int DeviceID)
        {
            db.OpenConnection();
            string query = "DELETE FROM Devices WHERE DeviceID =@DeviceID";
            using(MySqlCommand cmd =new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@DeviceID", DeviceID);
                bool result = cmd.ExecuteNonQuery() > 0;
                db.CloseConnection();
                return result;
            }
        }
        public List<DeviceModel> SearchDevices(string keyword)
        {
            List<DeviceModel> devices = new List<DeviceModel>();
            db.OpenConnection();

            string query = @"
        SELECT * FROM Devices 
        WHERE DeviceName LIKE @Keyword";

            bool isNumber = int.TryParse(keyword, out int deviceID);
            if (isNumber)
            {
                query += " OR DeviceID = @DeviceID";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
            {
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                if (isNumber)
                    cmd.Parameters.AddWithValue("@DeviceID", deviceID);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        devices.Add(new DeviceModel(
                            reader.GetInt32("DeviceID"),
                            reader.GetString("DeviceName"),
                            reader.GetString("DeviceImage"),
                            reader.GetString("DeviceType"),
                            reader.GetInt32("Quantity"),
                            (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                            reader.GetInt32("fee_per_hour")
                        ));
                    }
                }
            }

            db.CloseConnection();
            return devices;
        }

    }
}
