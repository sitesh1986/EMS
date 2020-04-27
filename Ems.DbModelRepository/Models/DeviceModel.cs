using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    public class DeviceModel:BaseModel
    {
        public string DeviceSerialNumber { get; set; }
        public int MeterConnected { get; set; }
        public string MeterMake { get; set; }

    }
}
