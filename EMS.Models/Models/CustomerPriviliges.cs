using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ModelsRepository.Models
{
    public class CustomerPriviliges
    {
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public int PrivilegeId { get; set; }
        public Priviliges Priviliges { get; set; }
    }
}
