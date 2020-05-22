using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Common.ViewModels;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ReportManager _reportManager;
        public ReportController(ReportManager reportManager)
        {
            _reportManager = reportManager;
        }
        [HttpPost("HistoricalData")]
        public async Task<IActionResult> GetHistoricalData(ReportParameterViewModel data)
        {
            var historical = await _reportManager.GetHistoricalData(data.parameter,data.fields,data.StartDate,data.EndDate);
            return Ok(historical);
        }
    }
}