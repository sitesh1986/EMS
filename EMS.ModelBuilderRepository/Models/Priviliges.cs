using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ModelBuilderRepository.Models
{
    public class Priviliges:BaseModel
    {
        public string PrivilegeName { get; set; }
        public  Customer Customer { get; set; }
    }
}
