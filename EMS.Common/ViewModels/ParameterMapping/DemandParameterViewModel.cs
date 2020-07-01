using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels.ParameterMapping
{
    public class DemandParameterViewModel
    {
        [JsonProperty("Maximum Demand")]
        public float MAXIMAMDEMAND { get; set; }
        [JsonProperty("Rising Demand")]
        public float RISINGDEMAND { get; set; }
        [JsonProperty("Demand-1")]
        public float DEMAND1 { get; set; }
        [JsonProperty("Demand-2")]
        public float DEMAND2 { get; set; }
        [JsonProperty("Demand-3")]
        public float DEMAND3 { get; set; }
    }
}
