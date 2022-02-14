using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DashboardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public OrderController(IRepositoryWrapper repository) => _repository = repository;

        [HttpGet("page/{page}")]
        public async Task<ActionResult> Get(int page)
        {
            // todo: implementar service layer
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _repository.Order.ReadAllOrdersAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Order order)
        {
            var ord = new Order
            {
                Address = new Address
                {
                    City = "POA",
                    Number = 546,
                    Street = "Avenida Caí",
                    CreatedAt = DateTime.Now
                },
                DeliveredAt = DateTime.MaxValue,
                Package = new Package
                {
                    Team = new Team
                    {
                        Description = "time",
                        Name = "name",
                        CreatedAt = DateTime.Now
                    },
                    CreatedAt = DateTime.Now,
                    
                },
                CreatedAt = DateTime.Now
            };
            return Ok(await _repository.Order.CreateOrderAsync(ord));
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