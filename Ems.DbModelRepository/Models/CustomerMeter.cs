using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    public class CustomerMeter
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MeterId { get; set; }
    }
}
