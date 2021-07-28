using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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
        public async Task<ActionResult<IList<MenuDto>>> GetMeals()
        {
            try
            {
                var menu = await _uow.Menu.GetAll();
                var result = _mapper.Map<IList<MenuDto>>(menu);

                return Ok(result);
            }
            catch (Exception e)
            {
                return Problem("Internal server error");
            }
        }
    }
}