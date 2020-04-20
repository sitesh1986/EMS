using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.DbModelRepository.Models
{
    public class Block:BaseModel
    {
        public string BlockName { get; set; }
        //value of A
        public int StartAddress { get; set; }
        //Value of C
        public int ModBusFC { get; set; }
        //Value Of D
        public int TotalReg { get; set; }
        //Value of F
        public int TotalParams { get; set; }

    }
}
