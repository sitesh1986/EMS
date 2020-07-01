using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    [Table("AllVendorMeter")]
    public class PM520L:BaseModel
    {
        public int ModBusAddress { get; set; }
        public string Parameter { get; set; }
        public string ModelName { get; set; }
    }
}
