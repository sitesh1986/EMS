using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels
{
    public class EMSCustomerViewModel
    {
        [JsonProperty("monitoring")]
        public bool Monitoring { get; set; }
        [JsonProperty("controlling")]
        public bool Controlling { get; set; }
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("password")]
        public string UserPassword { get; set; }
        [JsonProperty("no_of_plants")]
        public int NoOfPlants { get; set; }
        [JsonProperty("plant_address")]
        public string PlantAddress { get; set; }
        [JsonProperty("contact_person")]
        public string ContactPerson { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
        [JsonProperty("fax")]
        public string Fax { get; set; }
        [JsonProperty("social_media")]
        public string SocialMedia { get; set; }
        [JsonProperty("head_office")]
        public string HeadOffice { get; set; }
        [JsonProperty("contact_person")]
        public string ContatctPerson { get; set; }
        [JsonProperty("website")]
        public string WebSite { get; set; }
        [JsonProperty("gst_number")]
        public string GSTNumber { get; set; }
        [JsonProperty("pan")]
        public string PAN { get; set; }
        [JsonProperty("rr_number")]
        public string RRNumber { get; set; }
        [JsonProperty("tan")]
        public string TAN { get; set; }
        [JsonProperty("cin")]
        public string CIN { get; set; }
        [JsonProperty("uam")]
        public string UAM { get; set; }
        [JsonProperty("activity")]
        public string Activity { get; set; }
        [JsonProperty("incomers")]
        public int Incomers { get; set; }
        [JsonProperty("dg")]
        public int DG { get; set; }
        [JsonProperty("solar")]
        public int Solar { get; set; }
        [JsonProperty("demand")]
        public int Demand { get; set; }
        [JsonProperty("demand_charges")]
        public int DemandCharges { get; set; }
        [JsonProperty("penalty_charges")]
        public int PenaltyCharges { get; set; }
        [JsonProperty("no_of_transformers")]
        public int NoOfTransformers { get; set; }
        [JsonProperty("transformer1_rating")]
        public int Transformer1Rating { get; set; }
        [JsonProperty("transformer2_rating")]
        public int Transformer2Rating { get; set; }
        [JsonProperty("transformer3_rating")]
        public int Transformer3Rating { get; set; }
        [JsonProperty("transformer4_rating")]
        public int Transformer4Rating { get; set; }
        [JsonProperty("transformer5_rating")]
        public int Transformer5Rating { get; set; }
        [JsonProperty("no_of_machine")]
        public int NoOfMachine { get; set; }
        [JsonProperty("unit")]
        public int Unit { get; set; }
        [JsonProperty("licence_expiry")]
        public DateTime LicenceExpiry { get; set; }
        [JsonProperty("privileges")]
        public List<int> Privileges { get; set; }
        [JsonProperty("device_serial_no")]
        public string DeviceSerialNumber { get; set; }
        [JsonProperty("meters")]
        public List<int> Meters { get; set; }
    }
}
