using System;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.ViewModels;
using EMS.DbModelRepository.Models;
using EMS.Filters;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Mvc;
using EMS.Common.Constants;
namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMSCustomerController : ControllerBase
    {
        private CustomerManager _customerManager { get; set; }
        private readonly IMapper _mapper;
        public EMSCustomerController(CustomerManager customerManager, IMapper mapper)
        {
            _customerManager = customerManager;
            _mapper = mapper;
        }
        [HttpPost]
        [AssertPrivilege(PrivilegesConstant.SuperAdmin)]
        public async Task<IActionResult> Post(EMSCustomerViewModel customerViewModel)
        {
            try
            {
                var proCustomer = _mapper.Map<Customer>(customerViewModel);
                if (customerViewModel.Privileges.Count == 0)
                    customerViewModel.Privileges = null;
                var result = await _customerManager.CreateCustomer(proCustomer,customerViewModel.Privileges);
                var createdCustomer = _mapper.Map<EMSCustomerViewModel>(result);
                return Ok(createdCustomer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}