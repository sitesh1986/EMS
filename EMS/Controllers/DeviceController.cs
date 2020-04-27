using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EMS.Common.ViewModels;
using EMS.DbModelRepository.Models;
using EMS.ManagerRepository.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly DeviceManager _deviceManager;
        public DeviceController(DeviceManager deviceManager,IMapper mapper)
        {
            _deviceManager = deviceManager;
            _mapper = mapper;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Post(DeviceViewModel deviceViewModel)
        {
            var toBeCreateDevice = _mapper.Map<DeviceModel>(deviceViewModel);
            var device = await _deviceManager.CreateDevice(toBeCreateDevice);
            var createdDevice = _mapper.Map<DeviceViewModel>(device);
            return Ok(createdDevice);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Put(DeviceViewModel deviceViewModel)
        {
            var toBeUpdateDevice = _mapper.Map<DeviceModel>(deviceViewModel);
            var device = await _deviceManager.UpdateDevice(toBeUpdateDevice);
            var updatedDevice = _mapper.Map<DeviceViewModel>(device);
            return Ok(updatedDevice);
        }

        [HttpGet("SerialNo/{serialNo}")]
        public async Task<IActionResult> Get(string serialNo)
        {
            var device = await _deviceManager.GetDeviceBySerialNo(serialNo);
            return Ok(device);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var devices = await _deviceManager.GetDevices();
            return Ok(devices);
        }
        [HttpGet("Delete/{serialNo}")]
        public async Task<IActionResult> Delete(string serialNo)
        {
            var device = await _deviceManager.DeleteDevice(serialNo);
            return Ok(device);
        }
    }
}