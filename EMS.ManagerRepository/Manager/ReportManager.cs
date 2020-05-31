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
        public async Task<List<EmsMaster>> GetReportByMiuteData(List<int> parameter, List<string> fields, DateTime startDate, DateTime endDate, int minutes)
        {
            List<EmsMaster> ems = new List<EmsMaster>();
             startDate = startDate.Date.AddHours(00).AddMinutes(00).AddSeconds(00);
             endDate = endDate.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var masterData = await _emsRepository.GetWhere(x => parameter.Contains(x.SlaveId) && x.DateEms >= startDate && x.DateEms <= endDate);

            switch (minutes)
            {
                case 1:
                    var emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 1)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {
                        ems.AddRange(em);
                    }

                    break;
                case 15:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 15)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                       ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                case 30:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 30)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                        ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                case 45:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 45)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                        ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                case 60:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 60)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                        ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                case 1440:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 1440)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                        ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                case 43200:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 43200)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                        ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                case 518400:
                    emsDat = masterData.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / 51800)).Select(group => group.ToList()).ToList();
                    foreach (var em in emsDat)
                    {

                        ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                    }
                    break;
                default:
                    break;

            }

            return ems;
        }
    }
}
