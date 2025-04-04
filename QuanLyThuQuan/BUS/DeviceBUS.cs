using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;

namespace QuanLyThuQuan.BUS
{
    class DeviceBUS
    {
        private DeviceDAO deviceDAO = new DeviceDAO();

        public List<DeviceModel> GetAllDevices()
        {
            return deviceDAO.GetAllDevices();
        }

        public bool AddDevice(DeviceModel device)
        {
            // Có thể thêm kiểm tra nghiệp vụ tại đây nếu cần
            return deviceDAO.AddDevice(device);
        }

        public bool UpdateDevice(DeviceModel device)
        {
            // Kiểm tra nghiệp vụ trước khi cập nhật nếu cần
            return deviceDAO.UpdateDevice(device);
        }

        public bool DeleteDevice(int deviceID)
        {
            return deviceDAO.DeleteDevice(deviceID);
        }

        public List<DeviceModel> SearchDevices(string keyword)
        {
            return deviceDAO.SearchDevices(keyword);
        }
    }
}
