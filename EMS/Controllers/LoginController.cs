using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.ViewModels;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMS.DbModelRepository.Models;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginManager _loginManager { get; set; }
        private readonly IMapper _mapper;
        public LoginController(LoginManager loginManager, IMapper mapper)
        {
            _loginManager = loginManager;
            _mapper = mapper;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Post(LoginViewModel loginViewModel)
        {
            try
            {
                var toBeCreateCustomer = _mapper.Map<Customer>(loginViewModel);
                var user = await _loginManager.CheckUserCredential(toBeCreateCustomer);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}