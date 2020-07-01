using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels
{
    public class ReportParameterViewModel
    {
        public List<string> meter { get; set; }
        public List<string> parameter { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string interval { get; set; }
    }
}
