using System.Threading.Tasks;
using Bite_IT.Domain;
using Bite_IT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreWithReact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class IdentityController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IdentityController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(LoginEmployeeDto model)
        {
            var userFromDb = await _userManager.FindByNameAsync(model.UserName);

            if (userFromDb == null)
            {
                return BadRequest();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(userFromDb, model.Password, false);

            if (!result.Succeeded)
            {
                return BadRequest();
            }
            
            return Ok(new
            {
                result = result,
                username = userFromDb.UserName,
                email = userFromDb.Email,
                token = "Token goes here"
            });
        }
    }
}