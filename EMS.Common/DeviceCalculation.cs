using EMS.DbModelRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common
{
    public class DeviceCalculation
    {
        public static(int deviceId,DateTime emsDate) CalculateDevice(EmsDataReplication emsDataReplication)
        {
            int deviceId = 0;
            if(!string.IsNullOrEmpty(emsDataReplication.ID))
            {
                var deviceIdHex = emsDataReplication.ID.Replace(emsDataReplication.ID.Substring(0, 4), "");
                deviceId=  Convert.ToInt32(deviceIdHex, 16);
            }
            else
            {
                deviceId = Convert.ToInt32(emsDataReplication.DEV, 16);
            }
            string hexValue = emsDataReplication.DT;
            int secondsAfterEpoch = Int32.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            DateTime epoch = new DateTime(1970, 1, 1);
            DateTime myDateTime = epoch.AddSeconds(secondsAfterEpoch);
            int checkDate = Convert.ToInt32(emsDataReplication.DT);
            if (checkDate == 0)
                return (deviceId,DateTime.Now);
            return (deviceId, myDateTime.AddHours(5.30));
            
        }
    }
}
