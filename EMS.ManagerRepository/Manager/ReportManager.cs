using EMS.Common.DataCalculation;
using EMS.DbModelRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class ReportManager
    {
        private IEmsRepository<EmsMaster> _emsRepository { get; set; }
        public ReportManager(IEmsRepository<EmsMaster> emsRepository)
        {
            _emsRepository = emsRepository;
        }
        public async Task<List<EmsMaster>> GetHistoricalData(List<int> parameter, List<string> fields, DateTime startDate, DateTime EndDate)
        {
            List<EmsMaster> emsMasters = new List<EmsMaster>();
            var stDate = startDate.Date.AddHours(00).AddMinutes(00).AddSeconds(00);
            var enDate = EndDate.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var masterData = await _emsRepository.GetWhere(x => parameter.Contains(x.SlaveId) && x.DateEms >= stDate && x.DateEms <= enDate);
            emsMasters.Add(ReportCalculation.GetHistoricalDataCalculation(masterData.ToList()));
            return emsMasters;
        }
    }
}
