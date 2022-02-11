using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {
            
        }

        [HttpGet("page/{page}")]
        public async Task<ActionResult> Get(int page)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete() => throw new NotImplementedException();
    }
}