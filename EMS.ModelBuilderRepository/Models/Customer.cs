using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ModelBuilderRepository.Models
{
    public class Customer : BaseModel
    {
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int NoOfPlants { get; set; }
        public string PlantAddress { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string SocialMedia { get; set; }
        public string HeadOffice { get; set; }
        public string ContatctPerson { get; set; }
        public string WebSite { get; set; }
        public string GSTNumber { get; set; }
        public string PAN { get; set; }
        public string RRNumber { get; set; }
        public string TAN { get; set; }
        public string CIN { get; set; }
        public string UAM { get; set; }
        public string Activity { get; set; }
        public int Incomers { get; set; }
        public int DG { get; set; }
        public int Solar { get; set; }
        public int Demand { get; set; }
        public int DemandCharges { get; set; }
        public int PenaltyCharges { get; set; }
        public int NoOfTransformers { get; set; }
        public int Transformer1Rating { get; set; }
        public int Transformer2Rating { get; set; }
        public int Transformer3Rating { get; set; }
        public int Transformer4Rating { get; set; }
        public int Transformer5Rating { get; set; }
        public int NoOfMachine { get; set; }
        public int Unit { get; set; }
        public DateTime LicenceExpiry { get; set; }
        public bool Monitoring { get; set; }
        public bool Controlling { get; set; }
        public ICollection<Priviliges> Priviliges { get; set; }
    }
}
