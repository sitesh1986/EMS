using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterController : BaseController
    {
        private MeterManager _meterManager { get; set; }
        public MeterController(MeterManager meterManager)
        {
            _meterManager = meterManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var meters = await _meterManager.GetAll();
            return Ok(meters);
        }
        [HttpGet("CustomerMeter")]
        public async Task<IActionResult> GetCustomerMeter()
        {
            var customerId = base.CustomerId;
            var meters=await _meterManager.GetCustomerMetereByCustomerId(Convert.ToInt32(customerId));
            return Ok(meters);
        }
    }
}