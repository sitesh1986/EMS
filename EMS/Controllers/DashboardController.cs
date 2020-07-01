using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.ViewModels;
using EMS.DbModelRepository.Models;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ReportManager _reportManager;
        public DashboardController(ReportManager reportManager, IMapper mapper)
        {
            _reportManager = reportManager;
            _mapper = mapper;
        }
        [HttpPost("GetDashBoardByMinute")]
        public async Task<IActionResult> GetDashboardDataByMinuteData(ReportParameterViewModel data)
        {
            data.interval = "1";
            data.StartDate = DateTime.Now.AddHours(-24);
            data.EndDate = DateTime.Now;
            var historical = await _reportManager.GetReportByMiuteData(data.meter, data.parameter, data.StartDate, data.EndDate, data.interval);
            var mappedData = _mapper.Map<List<EmsMaster>, List<EMSMasterViewModel>>(historical);
            var serializeObject = JsonConvert.SerializeObject(mappedData);
            return Ok(serializeObject);
        }

        [HttpPost("GetDashBoardByHour")]
        public async Task<IActionResult> GetDashboardDataByHour(ReportParameterViewModel data)
        {
            data.interval = "60";
            data.StartDate = DateTime.Now.AddHours(-24);
            data.EndDate = DateTime.Now;
            var historical = await _reportManager.GetReportByMiuteData(data.meter, data.parameter, data.StartDate, data.EndDate, data.interval);
            var mappedData = _mapper.Map<List<EmsMaster>, List<EMSMasterViewModel>>(historical);
            var serializeObject = JsonConvert.SerializeObject(mappedData);
            return Ok(serializeObject);
        }

        [HttpPost("GetDashBoardByMonth")]
        public async Task<IActionResult> GetDashboardDataByMonth(ReportParameterViewModel data)
        {
            data.StartDate = DateTime.Now.AddDays(-30);
            data.EndDate = DateTime.Now;
            data.interval = "Month";
            var historical = await _reportManager.GetReportByMiuteData(data.meter, data.parameter, data.StartDate, data.EndDate, data.interval);
            var mappedData = _mapper.Map<List<EmsMaster>, List<EMSMasterViewModel>>(historical);
            var serializeObject = JsonConvert.SerializeObject(mappedData);
            return Ok(serializeObject);
        }
    }
}