using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common
{
    public static class DeviceHelper
    {
        public static string GetDeviceSerialNo(string serialNo)
        {
            string no = string.Empty;
            switch(serialNo)
            {
                case Constants.DeviceConstant.SmartfiCG:
                    no = "SFCG-001";
                    break;
                case Constants.DeviceConstant.SmartfiCW:
                    no = "SFCW-001";
                    break;
                case Constants.DeviceConstant.SmartfiGG:
                    no = "SFGG-001";
                    break;
                case Constants.DeviceConstant.SmartfiGW:
                    no = "SFGW-001";
                    break;
                case Constants.DeviceConstant.SmartfiMW:
                    no = "SFMW-001";
                    break;
            }
            return no;
        }
    }
}
