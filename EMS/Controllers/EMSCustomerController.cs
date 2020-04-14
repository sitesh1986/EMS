using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.ManagerRepository.Manager;
using EMS.ModelsRepository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMSCustomerController : ControllerBase
    {
        private CustomerManager _customerManager { get; set; }
        public EMSCustomerController(CustomerManager customerManager)
        {
            _customerManager = customerManager;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Customer customer)
        {
            try
            {
              bool result= await _customerManager.CreateCustomer(customer);
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