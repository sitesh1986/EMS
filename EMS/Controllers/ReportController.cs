using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.Constants;
using EMS.Common.ViewModels;
using EMS.Filters;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ReportManager _reportManager;
        public ReportController(ReportManager reportManager, IMapper mapper)
        {
            _reportManager = reportManager;
            _mapper = mapper;
        }
        [HttpPost("HistoricalData")]
        public async Task<IActionResult> GetHistoricalData(ReportParameterViewModel data)
        {
            var historical = await _reportManager.GetHistoricalData(data.parameter,data.fields,data.StartDate,data.EndDate);
            var mappedData= _mapper.Map<List<EMSMasterViewModel>>(historical);
            return Ok(mappedData);
        }
        [AssertPrivilege(PrivilegesConstant.SuperAdmin)]
        [HttpPost("ReportByInterval")]
        public async Task<IActionResult> GetReportByInterval(ReportParameterViewModel data)
        {
            var historical = await _reportManager.GetReportByMiuteData(data.parameter, data.fields, data.StartDate, data.EndDate,data.interval);
            var mappedData = _mapper.Map<List<EMSMasterViewModel>>(historical);
            return Ok(mappedData);
        }
    }
}