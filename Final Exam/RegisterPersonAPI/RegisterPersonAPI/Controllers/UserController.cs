﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Mappers.Interfaces;
using System.Net.Mime;
using System.Security.Claims;

namespace RegisterPersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUsersService _usersService;
        private readonly IJwtService _jwtService;
        private readonly IUserMapper _userMapper;
        private readonly IUsersRepository _usersRepository;

        public UserController(ILogger<UserController> logger, IUsersService usersService, IJwtService jwtService, IUserMapper userMapper, IUsersRepository usersRepository)
        {
            _logger = logger;
            _usersService = usersService;
            _jwtService = jwtService;
            _userMapper = userMapper;
            _usersRepository = usersRepository;
        }

        /// <summary>
        /// Login User to the system
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns>token value</returns>
        /// <response code="400">User validation error</response>
        /// <response code="200">Success, the user was logged in.</response>
        /// <response code="500">Server error</response>
        [HttpPost("login")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Login(UserLoginRequestDTO userLogin)
        {
            _logger.LogInformation($"Login attempt for {userLogin.UserName}");
            var user = _usersService.Login(userLogin.UserName, userLogin.Password);
            if (user == null)
            {
                _logger.LogWarning($"User {userLogin.UserName} not found");
                return BadRequest("User not found.");
            }
            var isPasswordValid = _usersService.VerifyPasswordHash(userLogin.Password, user.Password, user.PasswordSalt);
            if (!isPasswordValid)
            {
                _logger.LogWarning($"Invalid password for {userLogin.UserName}");
                return BadRequest("Incorrect password.");
            }
            _usersRepository.SaveLogin(user);
            _logger.LogInformation($"User {userLogin.UserName} successfully logged in");
            var token = _jwtService.GetJwtToken(user);
            return Ok(token);
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="createUser"></param>
        /// <returns>No contents</returns>
        /// <response code="400">User already exists in the database</response>
        /// <response code="201">Success, the new user was saved to database</response>
        /// <response code="500">Server error</response>
        [HttpPost("sign-up")]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult SignUp(UserCreateRequestDto createUser)
        {
            _logger.LogInformation($"Creating account for {createUser.UserName}");
            var user = _userMapper.Map(createUser);
            var userId = _usersService.Signup(user);
            if (userId == Guid.Empty)
            {
                _logger.LogWarning($"User {createUser.UserName} already exists");
                return BadRequest("User already exists in the database");
            }
            _logger.LogInformation($"Creating user by name {createUser.UserName}, id {userId.ToString().ToUpper()}");
            return Created("", new { id = userId });
        }

        /// <summary>
        /// Remove user, admin access
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="204">User Deleted</response>
        /// <response code="400">User ID does not exists</response>
        /// <response code="403">Unauthorised atempt</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Server error</response>
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(Guid id)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);

            _logger.LogWarning($"Delete attempt for user {id}");
            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);
            var userExists = _usersRepository.GetUserByGuid(userGuid);
            if(!checkGuid)
            {
                _logger.LogWarning($"Unauthorised attempt to delete {id}");
                return Forbid();
            }

            if (userExists == null)
            {
                _logger.LogInformation($"Account {id} not found");
                return BadRequest();
            }

            _logger.LogInformation($"Deleting account {id}");
            var userDeleted = _usersService.DeleteUserAndInformation(id);
            if (!userDeleted)
            {
                _logger.LogInformation($"Account {id} not found");
                return NotFound("User not found");
            }
            _logger.LogInformation($"Account {id} was deleted");
            return NoContent();
        }
    }
}
