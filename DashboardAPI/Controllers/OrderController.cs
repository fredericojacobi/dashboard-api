using System;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace DashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IServiceWrapper _service;
        private readonly IMapper _mapper;

        public OrderController(IServiceWrapper service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int currentPage, [FromQuery] int recordsPerPage)
        {
            return !_service.Token.Authenticate(HttpContext)
                ? Ok("User isn't authenticated.")
                : Ok(await _service.Order.ReadAllOrdersAsync(currentPage, recordsPerPage));
        }

        [HttpPost("Seed/{quantity}")]
        public async Task<IActionResult> Post([FromRoute] int quantity)
        {
            return Ok(await _service.Order.CreateMultipleOrdersAsync(quantity));
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }
    }
}