using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Common.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetParameter()
        {
            EMSMasterViewModel eMSMasterViewModel = new EMSMasterViewModel();
            var parameter = JsonConvert.SerializeObject(eMSMasterViewModel, Formatting.Indented);
            var deserializeJson = JsonConvert.DeserializeObject<Dictionary<string, string>>(parameter);
            var keys = deserializeJson.Where(key=>key.Key!="Date").Select(x => x.Key).ToList();
            return Ok(keys);
        }
    }
}