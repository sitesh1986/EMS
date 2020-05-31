using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    [Table("Venlite1")]
    public class PM520L:BaseModel
    {
        public int ModBusAddress { get; set; }
        public string Parameter { get; set; }
    }
}
