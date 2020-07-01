using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels.ParameterMapping
{
    public class PowerParameterViewModel
    {
        [JsonProperty("Watts-Tot")]
        public float WattsTot { get; set; }
        [JsonProperty("W-R")]
        public float WR { get; set; }
        [JsonProperty("W-Y")]
        public float WY { get; set; }
        [JsonProperty("W-B")]
        public float WB { get; set; }
        [JsonProperty("VA-Tot")]
        public float VATOT { get; set; }
        [JsonProperty("VA-R")]
        public float VAR { get; set; }
        [JsonProperty("VA-Y")]
        public float VAY { get; set; }
        [JsonProperty("VA-B")]
        public float VAB { get; set; }
        [JsonProperty("VAR-Tot")]
        public float VARTOT { get; set; }
        [JsonProperty("VAR-R")]
        public float VARR { get; set; }
        [JsonProperty("VAR-Y")]
        public float VARY { get; set; }
        [JsonProperty("VAR-B")]
        public float VARB { get; set; }
    }
}
