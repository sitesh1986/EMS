using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels
{
    public class ReportParameterViewModel
    {
        public List<int> parameter { get; set; }
        public List<string> fields { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
