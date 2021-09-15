using System;
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
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var pswrdValidation = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

                if (pswrdValidation.Succeeded)
                {
                    return Ok(new
                    {
                        result = pswrdValidation,
                        username = user.UserName,
                        email = user.Email,
                        token = "Token goes here"
                    });
                }
            }

            return BadRequest();
        }
        
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterEmployeeDto model)
        {
            var userToCreate = new Employee()
            {
                Email = model.Email,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                Role = 0,
                BirthDateTime = DateTime.Today,
                RestaurantId = 1
            };
            var result = await _userManager.CreateAsync(userToCreate, model.PasswordHash);
            Console.Out.WriteLine(result);
            if (result.Succeeded)
            {
                return Ok();
            }

            
            return BadRequest(result);
        }
    }
}