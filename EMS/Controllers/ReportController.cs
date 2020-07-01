using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.Constants;
using EMS.Common.ViewModels;
using EMS.DbModelRepository.Models;
using EMS.Filters;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        [HttpPost("HistoricalReport")]
        public async Task<IActionResult> GetHistoricalData(ReportParameterViewModel data)
        {

            var historical = await _reportManager.GetReportByMiuteData(data.meter,data.parameter,data.StartDate,data.EndDate, data.interval);
            var mappedData= _mapper.Map<List<EmsMaster>, List<EMSMasterViewModel>>(historical);
            var serializeObject = JsonConvert.SerializeObject(mappedData);
            return Ok(serializeObject);
        }
        //[AssertPrivilege(PrivilegesConstant.SuperAdmin)]
        //[HttpPost("ReportByInterval")]
        //public async Task<IActionResult> GetReportByInterval(ReportParameterViewModel data)
        //{
        //    EMSMasterViewModel eMSMasterView = new EMSMasterViewModel();
        //    var historical = await _reportManager.GetReportByMiuteData(data.meter, data.parameter, data.StartDate, data.EndDate,data.interval);
        //    var mappedData = _mapper.Map<List<EmsMaster>,List<EMSMasterViewModel>>(historical);

        //    var serializeObject = JsonConvert.SerializeObject(mappedData);
            
        //    return Ok(serializeObject);
        //}
    }
}