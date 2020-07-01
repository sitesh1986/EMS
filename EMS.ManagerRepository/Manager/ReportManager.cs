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
        private MeterManager _meterManager { get; set; }
        public ReportManager(IEmsRepository<EmsMaster> emsRepository, MeterManager meterManager)
        {
            _emsRepository = emsRepository;
            _meterManager = meterManager;
        }
        //public async Task<List<EmsMaster>> GetHistoricalData(List<string> parameter, List<string> fields, DateTime startDate, DateTime EndDate)
        //{
        //    List<EmsMaster> emsMasters = new List<EmsMaster>();
        //    var stDate = startDate.Date.AddHours(00).AddMinutes(00).AddSeconds(00);
        //    var enDate = EndDate.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
        //    var meterId = await _meterManager.GetMeterIdByName(parameter);
        //    var masterData = await _emsRepository.GetWhere(x => meterId.Contains(x.SlaveId) && x.DateEms >= stDate && x.DateEms <= enDate);
        //    emsMasters.Add(ReportCalculation.GetHistoricalDataCalculation(masterData.ToList()));
        //    return emsMasters;
        //}

        public void CheckEmptyData(long startTSInTicks, long endTsInTicks, long ticksPerintervalMin, List<EmsMaster> ems,int minutes=0)
        {
            for (long i = startTSInTicks; i <= endTsInTicks; i += ticksPerintervalMin)
            {
                var dat = new DateTime(i);
                var endDat = dat.AddMinutes(minutes);
                var existingData = ems.Any(x => x.DateEms.Ticks >= dat.Ticks && x.DateEms.Ticks <= endDat.Ticks);
                if (!existingData)
                {
                    if (i > startTSInTicks)
                    {
                        ems.Add(new EmsMaster
                        {
                            DateEms = dat
                        });
                    }
                }
            }
        }
        public async Task<List<EmsMaster>> GetReportByMiuteData(List<string> parameter, List<string> fields, DateTime startDate, DateTime endDate, string interval)
        {
            int minutes = 0;
           
            TimeSpan rs = endDate - startDate;
            List<EmsMaster> ems = new List<EmsMaster>();
            switch (interval.ToUpper())
            {
                case "1":
                    minutes = 1;
                    break;
                case "15":
                    minutes = 15;
                    break;
                case "30":
                    minutes = 30;
                    break;
                case "45":
                    minutes = 45;
                    break;

                case "60":
                    minutes = 60;
                    break;
                case "24":
                    minutes = Convert.ToInt32(rs.TotalMinutes);
                    break;
                case "MONTH":
                    minutes = Convert.ToInt32(rs.TotalMinutes);
                    break;
                case "YEAR":
                    minutes = Convert.ToInt32(rs.TotalMinutes);
                    break;
            }
            var meterId = await _meterManager.GetMeterIdByName(parameter);
            long ticksPerSecond = 10000000;
            long ticksPerMinute = ticksPerSecond * 60;
            long ticksPerintervalMin = ticksPerMinute * minutes;
            long startTSInTicks = startDate.Ticks;
            long endTsInTicks = endDate.Ticks;
            foreach (var metId in meterId)
            {
                var slaveId = await _emsRepository.GetWhere(x => x.SlaveId.Equals(metId) && x.DateEms >= startDate && x.DateEms <= endDate);
                if (slaveId.Count() > 0)
                {
                    var emsDat = slaveId.GroupBy(y => (int)(y.DateEms.Ticks / TimeSpan.TicksPerMinute / minutes)).Select(group => group.ToList()).ToList();
                   if(minutes==1)
                    {
                        foreach (var em in emsDat)
                        {
                            ems.AddRange(em);
                        }
                    }
                   else
                    {
                        foreach (var em in emsDat)
                        {
                            ems.Add(ReportCalculation.GetHistoricalDataCalculation(em.ToList()));
                        }
                    }
                   
                   
                    CheckEmptyData(startTSInTicks, endTsInTicks, ticksPerintervalMin, ems,minutes);
                }
                else
                {
                    for (long i = startTSInTicks; i <= endTsInTicks; i += ticksPerintervalMin)
                    {
                        if (i > startTSInTicks)
                        {
                            ems.Add(new EmsMaster
                            {
                                DateEms = new DateTime(i),
                                SlaveId = metId
                            });
                        }
                    }
                }
            }
            return ems.OrderByDescending(x => x.DateEms).ToList();
        }
    }

}
