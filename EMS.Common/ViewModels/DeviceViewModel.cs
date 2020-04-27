using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels
{
    public class DeviceViewModel
    {
        [JsonProperty("device_serial_no")]
        public string DeviceSerialNumber { get; set; }
        [JsonProperty("meter_connected")]
        public int MeterConnected { get; set; }
        [JsonProperty("meter_make")]
        public string MeterMake { get; set; }
    }
}
