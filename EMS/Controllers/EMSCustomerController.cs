using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.ViewModels;
using EMS.ManagerRepository.Manager;
using EMS.ModelBuilderRepository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMSCustomerController : ControllerBase
    {
        private CustomerManager _customerManager { get; set; }
        private readonly IMapper _mapper;
        public EMSCustomerController(CustomerManager customerManager,IMapper mapper)
        {
            _customerManager = customerManager;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Post(EMSCustomerViewModel customerViewModel)
        {
            try
            {
                var proCustomer = _mapper.Map<Customer>(customerViewModel);
                bool result= await _customerManager.CreateCustomer(proCustomer);
                if (result)
                    return Ok(result);
                else
                    return BadRequest("Customer not created");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}