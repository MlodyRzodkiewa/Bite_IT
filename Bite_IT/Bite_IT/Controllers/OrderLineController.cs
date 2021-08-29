using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Infrastructure;
using Bite_IT.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Bite_IT.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class OrderLineController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public OrderLineController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateOrderLine([FromBody] CreateOrderLineDto orderLineDto)
        {
            try
            {
                var orderLine = _mapper.Map<OrderLine>(orderLineDto);
                await _uow.OrderLines.Add(orderLine);
                await _uow.Save();

                return CreatedAtRoute("GetOrderLines", new {id = orderLine.OrderId}, orderLine);
            }
            catch (Exception e)
            {
                return Problem("Internal server error");
            }
            
        }
        
        [HttpGet("{id:int}", Name="GetOrderLines")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<OrderLineDto>>> GetOrderLines(int id) //by OrderId !!!???
        {
            try
            {
                var orderLines = await _uow.OrderLines.GetAll(c => c.OrderId == id,
                    includes: new List<string> {"Meal"});

                if (orderLines == null)
                {
                    return NotFound($"Not found orderLine with orderId = {id}");
                }

                var result = _mapper.Map<IList<OrderLineDto>>(orderLines);
                return Ok(result);
            }
            catch (Exception e)
            {
                return Problem("Internal server error, please try again");
            }
        }
        
        
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteOrderLine(int id)
        {

            if (id < 1)
            {
                return BadRequest();
            }
            try
            {
                var orderLine = await _uow.OrderLines.Get(c => c.Id == id);

                if (orderLine == null)
                {
                    return NotFound($"Not found orderLine with id = {id}");
                }
                
                await _uow.OrderLines.Remove(id);
                await _uow.Save();
                return NoContent();
            }
            catch (Exception e)
            {
                return Problem("Internal server error, please try again");
            }
            
        }
        [HttpDelete("{orderId}/{mealId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteMealsFromOrder(int mealId, int orderId)
        {

            if (orderId < 1 || mealId < 1)
            {
                return BadRequest();
            }
            try
            {
                var orderLinesToRemove = await _uow.OrderLines.GetAll(c => c.OrderId == orderId);
                var orderLineToRemove = orderLinesToRemove.FirstOrDefault(x => x.MealId == mealId);

                if (orderLineToRemove == null)
                {
                    return NotFound($"Not found orderLine to remove");
                }
                
                await _uow.OrderLines.Remove(orderLineToRemove.Id);
                await _uow.Save();
                return Ok("Line remove");
            }
            catch (Exception e)
            {
                return Problem("Internal server error, please try again");
            }
            
        }
    }
}