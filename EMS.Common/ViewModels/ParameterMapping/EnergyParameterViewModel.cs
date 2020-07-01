using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels.ParameterMapping
{
    public class EnergyParameterViewModel
    {
        [JsonProperty("Wh(Consumed)-Total")]
        public float WHCONTOT { get; set; }
        [JsonProperty("Wh(C)-R")]
        public float WHCR { get; set; }
        [JsonProperty("Wh(C)-Y")]
        public float WHCY { get; set; }
        [JsonProperty("Wh(C)-B")]
        public float WHCB { get; set; }
        [JsonProperty("Wh(Generated)-Total")]
        public float WHGENTOT { get; set; }
        [JsonProperty("Wh(G)-R")]
        public float WHGR { get; set; }
        [JsonProperty("Wh(G)-Y")]
        public float WHGY { get; set; }
        [JsonProperty("Wh(G)-B")]
        public float WHGB { get; set; }
        [JsonProperty("Vah(Consumed)-Total")]
        public float VAHCONTOT { get; set; }
        [JsonProperty("Vah(C)-R")]
        public float VAHCR { get; set; }
        [JsonProperty("Vah(C)-Y")]
        public float VAHCY { get; set; }
        [JsonProperty("Vah(C)-B")]
        public float VAHCB { get; set; }
        [JsonProperty("Vah(Generated)-Total")]
        public float VAHGENTOT { get; set; }
        [JsonProperty("Vah(G)-R")]
        public float VAHGR { get; set; }
        [JsonProperty("Vah(G)-Y")]
        public float VAHGY { get; set; }
        [JsonProperty("Vah(G)-B")]
        public float VAHGB { get; set; }
        [JsonProperty("Varh-Total")]
        public float VARHTOT { get; set; }
        [JsonProperty("Varh-R")]
        public float VARHR { get; set; }
        [JsonProperty("Varh-Y")]
        public float VARHY { get; set; }
        [JsonProperty("Varh-B")]
        public float VARHB { get; set; }
        [JsonProperty("Varh-Cap-Total")]
        public float VARHCAPT { get; set; }
        [JsonProperty("Varh-Cap-R")]
        public float VARHCAPR { get; set; }
        [JsonProperty("Varh-Cap-Y")]
        public float VARHCAPY { get; set; }
        [JsonProperty("Varh-Cap-B")]
        public float VARHCAPB { get; set; }
        [JsonProperty("Varh-Ind-Total")]
        public float VARHINDT { get; set; }
        [JsonProperty("Varh-Ind-R")]
        public float VARHINDR { get; set; }
        [JsonProperty("Varh-Ind-Y")]
        public float VARHINDY { get; set; }
        [JsonProperty("Varh-Ind-B")]
        public float VARHINDB { get; set; }
    }
}
