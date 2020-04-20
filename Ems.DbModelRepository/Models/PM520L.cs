using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    public class PM520L:BaseModel
    {
        public int ModBusAddress { get; set; }
        public string Parameter { get; set; }
    }
}
