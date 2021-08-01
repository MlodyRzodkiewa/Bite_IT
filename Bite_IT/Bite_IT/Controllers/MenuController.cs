using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bite_IT.Domain;
using Bite_IT.Infrastructure;
using Bite_IT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bite_IT.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        //private readonly ILogger<MenuController> _logger;

        public MenuController(IUnitOfWork uow, IMapper mapper) //, ILogger<MenuController> logger)
        {
            _uow = uow;
            _mapper = mapper;
            //_logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MenuDto>> GetMenu()
        {
            try
            {
                var menu = await _uow.Menu.Get(m => m.RestaurantId == 1);

                if (menu == null) return NotFound($"Menu for the restaurant has not been found.");
                
                menu.Meals = (List<Meal>) await _uow.Meals.GetAll(meal => meal.MenuId == menu.Id);
                
                foreach (var meal in menu.Meals)
                {
                    meal.Ingredients = await _uow.Ingredients.GetAll(
                        ingredient => meal.Ingredients.Contains(ingredient));
                }

                var result = _mapper.Map<MenuDto>(menu);
        
                return Ok(result);
            }
            catch (Exception e)
            {
                return Problem("Internal server error");
            }
        }
    }
}