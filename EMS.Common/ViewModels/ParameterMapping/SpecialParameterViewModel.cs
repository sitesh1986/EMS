using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels.ParameterMapping
{
    public class SpecialParameterViewModel
    {
        [JsonProperty("RPM")]
        public float RPM { get; set; }
        [JsonProperty("Un Balance Voltage Vll")]
        public float UNBALANCEVOLTAGEVLL { get; set; }
        [JsonProperty("Un Balance Voltage VlN")]
        public float UNBALANCEVOLTAGEVLN { get; set; }
        [JsonProperty("Un Balance Current Amps")]
        public float UNBALANCECURRENTAMPS { get; set; }
        [JsonProperty("Neutral Current (I-N)")]
        public float NEUTRALCURRENTLN { get; set; }
    }
}
