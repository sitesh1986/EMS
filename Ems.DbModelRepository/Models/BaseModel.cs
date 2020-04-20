using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
