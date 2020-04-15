using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.ManagerRepository.Manager;
using EMS.ModelBuilderRepository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmsBlockController : ControllerBase
    {
        private EmsBlockManager _emsBlockManager { get; set; }
        public EmsBlockController(EmsBlockManager emsBlockManager)
        {
            _emsBlockManager = emsBlockManager;
        }
        [HttpPost]
        public async Task<IActionResult> Post(Block block)
        {
            try
            {
                var result = await _emsBlockManager.CreateBlock(block);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest("Error in creating Blocks");
            }
          
        }
    }
}