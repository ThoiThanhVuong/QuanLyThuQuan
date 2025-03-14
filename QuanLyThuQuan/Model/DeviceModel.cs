using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Model
{
    class DeviceModel
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceImage { get; set; }
        public string DeviceType { get; set; }
        public int DeviceQuantity { get; set; }
        public ProductStatus DeviceStatus { get; set; }
        public DeviceModel()
        {
            
        }

        public DeviceModel(int deviceID, string deviceName, string deviceImage, string deviceType, int deviceQuantity, ProductStatus deviceStatus)
        {
            DeviceID = deviceID;
            DeviceName = deviceName;
            DeviceImage = deviceImage;
            DeviceType = deviceType;
            DeviceQuantity = deviceQuantity;
            DeviceStatus = deviceStatus;
        }
    }
}
