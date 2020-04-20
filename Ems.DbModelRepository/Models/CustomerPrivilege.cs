using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    public class CustomerPrivilege:BaseModel
    {
        public int CustomerId { get; set; }
        
        public int PrivilegeId { get; set; }
       
    }
}
