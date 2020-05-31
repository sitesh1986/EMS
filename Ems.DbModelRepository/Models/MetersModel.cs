using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    [Table("MeterMaster")]
    public class MetersModel
    {
        public int Id { get; set; }
        public string MeterName { get; set; }
    }
}
