using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels.ParameterMapping
{
    public class BasicParameterViewModel
    {
        [JsonProperty("Date")]
        public DateTime DateEms { get; set; }
        [JsonProperty("MeterId")]
        public int SlaveId { get; set; }
        [JsonProperty("VLL-Avg")]
        public float VLLAVG { get; set; }
        [JsonProperty("VRY")]
        public float VRY { get; set; }
        [JsonProperty("VYB")]
        public float VYB { get; set; }
        [JsonProperty("VBR")]
        public float VBR { get; set; }
        [JsonProperty("VLN-Avg")]
        public float VLNAVG { get; set; }
        [JsonProperty("VR")]
        public float VR { get; set; }
        [JsonProperty("VY")]
        public float VY { get; set; }
        [JsonProperty("VB")]
        public float VB { get; set; }
        [JsonProperty("Current-Avg")]
        public float IAVG { get; set; }
        [JsonProperty("Current-R")]
        public float IR { get; set; }
        [JsonProperty("Current-Y")]
        public float IY { get; set; }
        [JsonProperty("Current-B")]
        public float IB { get; set; }
        [JsonProperty("Frequency(Hz)")]
        public float HZ { get; set; }
        [JsonProperty("PF-Avg")]
        public float PFAVG { get; set; }
        [JsonProperty("PF-R")]
        public float PFR { get; set; }
        [JsonProperty("PF-Y")]
        public float PFY { get; set; }
        [JsonProperty("PF-B")]
        public float PFB { get; set; }
    }
}
