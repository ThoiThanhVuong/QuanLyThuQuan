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
            return deviceDAO.GetAllDevices();
        }
        public DeviceModel GetDeviceByID(int Id)
        {
            return deviceDAO.GetDeviceByID(Id);
            
        }

        public DeviceModel GetDeviceByName(string name)
        {
            return deviceDAO.GetDeviceByName(name);
        }
        public List<string> GetDeviceType()
        {
            return deviceDAO.GetDeviceType();
        }
        public List<DeviceModel> GetDeviceByType(string type)
        {
            return deviceDAO.GetDeviceByType(type);
        }
        public bool AddDevice(DeviceModel device)
        {
           
            return deviceDAO.AddDevice(device);
        }

        public bool UpdateDevice(DeviceModel device)
        {
            
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
