using System;
using System.Drawing;
using System.Threading.Tasks;
using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Infrastructure;
using Bite_IT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bite_IT.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public OrderController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto orderDto)
        {
            try
            {
                var order = _mapper.Map<Order>(orderDto);
                await _uow.Orders.Add(order);
                await _uow.Save();

                return CreatedAtRoute("GetOrder", new {id = order.Id}, order);
            }
            catch (Exception e)
            {
                return Problem("Internal server error");
            }
            
        }
        [HttpGet("{id:int}", Name="GetOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<OrderDto>> GetOrder(int id)
        {
            
            try
            {
                var order = await _uow.Orders.Get(c => c.Id == id);

                if (order == null)
                {
                    return NotFound($"Not found order with id = {id}");
                }

                var result = _mapper.Map<OrderDto>(order);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Problem("Internal server error, please try again");
            }
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] UpdateOrderLineDto orderLineDto)
        {
            try
            {
                var order = await _uow.Orders.Get(c => c.Id == id);

                if (order == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(orderLineDto, order);
                _uow.Orders.Modify(order);
                await _uow.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return Problem("Internal server error, please try again");
            }
        }
        
    }
}