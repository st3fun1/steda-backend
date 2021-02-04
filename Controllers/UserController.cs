using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Steda_backend.Models;
using Microsoft.AspNetCore.Identity;

namespace Steda_backend.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {
        AppDbContext _appDbContext;
        SignInManager<AppUser> _signInManager;

        UserManager<AppUser> _userManager;
        public UserController(AppDbContext appDbContext, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager) {
            _appDbContext = appDbContext;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(LoginData model) {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null) {
                return Unauthorized();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            
            if (result.Succeeded) {
                return new User {
                    DisplayName = user.DisplayName,
                    Token = "",
                    Username = user.UserName,
                    Image = null
                };
            }

            return Unauthorized();
        }
    }
}