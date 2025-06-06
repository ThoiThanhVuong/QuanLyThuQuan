﻿namespace ThuQuanWebForm.Model
{
    public class DeviceModel
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceImage { get; set; }
        public string DeviceType { get; set; }
        public int DeviceQuantity { get; set; }

        public ProductStatus DeviceStatus { get; set; }
        public int FeePerHour { get; set; }
        public DeviceModel()
        {

        }

        public DeviceModel(string deviceName, string deviceImage, string deviceType, int deviceQuantity, ProductStatus deviceStatus, int feePerHour)
        {
            DeviceName = deviceName;
            DeviceImage = deviceImage;
            DeviceType = deviceType;
            DeviceQuantity = deviceQuantity;
            DeviceStatus = deviceStatus;
            FeePerHour = feePerHour;
        }

        public DeviceModel(int deviceID, string deviceName, string deviceImage, string deviceType, int deviceQuantity, ProductStatus deviceStatus, int feePerHour)
        {
            DeviceID = deviceID;
            DeviceName = deviceName;
            DeviceImage = deviceImage;
            DeviceType = deviceType;
            DeviceQuantity = deviceQuantity;

            DeviceStatus = deviceStatus;
            FeePerHour = feePerHour;
        }
        public override string ToString()
        {
            return $"{DeviceID} - {DeviceName} -{DeviceImage}- {DeviceType} - {FeePerHour} - {DeviceQuantity} - {DeviceStatus}";
        }
    }
}
