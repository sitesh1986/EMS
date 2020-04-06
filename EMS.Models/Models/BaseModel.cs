using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ModelsRepository.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
