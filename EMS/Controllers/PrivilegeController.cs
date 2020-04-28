using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Common.Constants;
using EMS.Filters;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrivilegeController : BaseController
    {
        private PrivilegeManager _privilegeManager { get; set; }
        public PrivilegeController(PrivilegeManager privilegeManager)
        {
            _privilegeManager = privilegeManager;
        }
        [AssertPrivilege(PrivilegesConstant.SuperAdmin)]
        [HttpGet("GetCustomerPrivileges")]
        public async Task<IActionResult> GetCustomerPrivileges()
        {
            var customerId = base.CustomerId;
            var privileges = await _privilegeManager.GetCustomerPrivilegesNamesById(Convert.ToInt32(customerId));
            return Ok(privileges);
        }
    }
}