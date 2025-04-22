using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuQuan.BUS
{
    class DeviceBUS
    {
        private DeviceDAO deviceDAO = new DeviceDAO();

        public List<DeviceModel> GetAllDevices()
        {
            return deviceDAO.GetAllDevices().ToList();
        }
        public DeviceModel GetDeviceByID(int Id)
        {
            DeviceModel device = deviceDAO.GetDeviceByID(Id);
            if (device == null)
                return null;
            return new DeviceModel(device.DeviceID, device.DeviceName, device.DeviceImage, device.DeviceType, device.DeviceQuantity, device.DeviceStatus, device.FeePerHour);
        }

        public DeviceModel GetDeviceByName(string name)
        {
            DeviceModel device = deviceDAO.GetDeviceByName(name);
            if (device == null)
                return null;
            return new DeviceModel(device.DeviceID, device.DeviceName, device.DeviceImage, device.DeviceType, device.DeviceQuantity, device.DeviceStatus, device.FeePerHour);
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
            if (string.IsNullOrEmpty(keyword.Trim()))
                return (deviceDAO.GetAllDevices()).ToList();
            return (deviceDAO.SearchDevices(keyword)).ToList();
        }

        public int GetTotalDeviceQuantity()
        {
            return deviceDAO.GetTotalDeviceQuantity();
        }
    }
}
