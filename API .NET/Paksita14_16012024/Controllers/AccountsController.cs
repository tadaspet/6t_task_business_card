using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paksita14_16012024.BussinessLogic;
using Paksita14_16012024.DTOs;
using UnitTestPracticeApplication.Services;

namespace Paksita14_16012024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserManagerService _userManagerService;
        private readonly IJWtService _jWtService;

        public AccountsController(IUserManagerService userManagerService, IJWtService jWtService)
        {
            _userManagerService = userManagerService;
            _jWtService = jWtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var loginSuccess = _userManagerService.TryLogin(dto.UserName, dto.Password, out var role, out int? userId);
            if (!loginSuccess)
            {
                return BadRequest("Wrong");
            }
            var token = _jWtService.GetJwtToken((int) userId, dto.UserName, role);
            return Ok(token);
        }

        [HttpPost("SingUp")]
        public IActionResult Register(SignUpUserDto dto)
        {
            var user = _userManagerService.CreateAccount(dto.UserName, dto.Password, dto.Email, dto.Role);
            if (user == null)
            {
                return BadRequest("User already exists");
            }
            return Ok();
        }
    }
}
