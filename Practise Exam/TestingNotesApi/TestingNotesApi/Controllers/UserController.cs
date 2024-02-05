using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoteKeeper.Api.DTOs;
using System.Net.Mime;
using TestingNotesApi.Api.DTOs;
using TestingNotesApiBLL.Interfaces;

namespace TestingNotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class UserController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IUsersService _usersService;

        public UserController(IJwtService jwtService, IUsersService usersService)
        {
            _jwtService = jwtService;
            _usersService = usersService;
        }

        /// <summary>
        /// Login User to the system
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns>token value</returns>
        /// <response code="404">User was not found</response>
        /// <response code="200">Success, the user was logged in.</response>
        [HttpPost("login")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Login(UserLoginDTO userLogin)
        {
            var user = _usersService.Login(userLogin.Username, userLogin.Password);
            if (user is null)
            {
                return NotFound();
            }
            var token = _jwtService.GetJwtToken(userLogin.Username, user.Id);
            return Ok(token);
        }

        /// <summary>
        /// Create new user in the database
        /// </summary>
        /// <param name="createUser"></param>
        /// <returns>No contents</returns>
        /// <response code="400">User already exists in the database</response>
        /// <response code="201">Success, the new user was saved to database</response>
        [HttpPost("sign-up")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult SignUp(UserCreateDTO createUser)
        {
            var userId = _usersService.Signup(createUser.Username, createUser.Password, createUser.Email);
            if (userId == 0)
            {
                return BadRequest("User already exists in the database");
            }
            string newUserUri = $"/users/{userId}";
            return Created(newUserUri, null);

        }
    }
}
