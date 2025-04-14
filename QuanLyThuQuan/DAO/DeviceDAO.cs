using MySql.Data.MySqlClient;
using QuanLyThuQuan.AppConfig;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;

namespace QuanLyThuQuan.DAO
{
    class DeviceDAO
    {
        private ConnectDB db = new ConnectDB();

        public List<DeviceModel> GetAllDevices()
        {
            List<DeviceModel> devices = new List<DeviceModel>();
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Devices WHERE Status IN ('Available','OutOf')";
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
                            (ProductStatus)Enum.Parse(typeof(ProductStatus), reader.GetString("Status")),
                            reader.GetInt32("fee_per_hour")
                     ));
                }
                reader.Close();
                db.OpenConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy sách " + ex.Message);
            }

            return devices;
        }
        public DeviceModel GetDeviceByID(int Id)
        {
            DeviceModel device = null;

            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM Devices WHERE DeviceID = @Id AND Status IN ('Available','OutOf')";

                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            device = (new DeviceModel(
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy thiết bị: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return device;
        }

        public bool AddDevice(DeviceModel device)
        {
            try
            {
                db.OpenConnection();
                string query = "INSERT INTO Devices (DeviceName,DeviceImage,DeviceType,Quantity,Status,fee_per_hour)" +
                    "VALUES (@DeviceName,@DeviceImage,@DeviceType,@Quantity,@Status,@fee_per_hour)";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm sách " + ex.Message);
                return false;
            }


        }
        public bool UpdateDevice(DeviceModel device)
        {
            try
            {
                db.OpenConnection();
                string query = ("UPDATE Devices " +
                    "SET DeviceName=@DeviceName ,DeviceImage=@DeviceImage,DeviceType=@DeviceType,Quantity=@Quantity,Status=@Status,fee_per_hour=@fee_per_hour" +
                    "WHERE DeviceID =@DeviceID");
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi chỉnh sửa sách " + ex.Message);
                return false;
            }


        }
        public bool DeleteDevice(int DeviceID)
        {
            try
            {
                db.OpenConnection();
                string query = "UPDATE Devices SET Status='Unavailable' WHERE DeviceID =@DeviceID";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@DeviceID", DeviceID);
                    bool result = cmd.ExecuteNonQuery() > 0;
                    db.CloseConnection();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sách " + ex.Message);
                return false;
            }

        }
        public List<DeviceModel> SearchDevices(string keyword)
        {
            List<DeviceModel> devices = new List<DeviceModel>();
            try
            {
                db.OpenConnection();

                string query = @"
                    SELECT * FROM Devices 
                    WHERE DeviceName LIKE @Keyword AND Status IN ('Available','OutOf')";

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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm sách " + ex.Message);
            }
            return devices;
        }


        public int GetTotalDeviceQuantity()
        {
            int total = 0;
            try
            {
                db.OpenConnection();
                string query = "SELECT SUM(Quantity) FROM Devices";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    total = Convert.ToInt32(result);
                }
                db.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tổng số lượng thiết bị " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            return total;
        }
    }
}
