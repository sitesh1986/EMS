using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EMS.Common.ViewModels;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMSMasterController : ControllerBase
    {
        private EmsMasterManager _emsMasterManager;
        public EMSMasterController(EmsMasterManager emsMasterManager)
        {
            _emsMasterManager = emsMasterManager;
        }
        //[Route("Create")]
        [HttpPost("Create")]
        public async Task<IActionResult> Post()
        {
            string body = string.Empty;
            using (var reader = new StreamReader(Request.Body))
            {
                 body = await reader.ReadToEndAsync();

                // Do something
            }
            var data=await _emsMasterManager.Create(body);
            return Ok(data);
        }
    }
}