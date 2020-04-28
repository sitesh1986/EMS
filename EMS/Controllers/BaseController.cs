using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public string CustomerId
        {
            get
            {
                var httpeRequest = new HttpRequestMessage();

                return HttpContext.Request.Headers["CustomerId"].ToString();
            }
        }
    }
}