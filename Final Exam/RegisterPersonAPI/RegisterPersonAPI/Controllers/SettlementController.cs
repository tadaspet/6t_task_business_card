using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonAPI.DTOs.Requests;
using RegisterPersonAPI.DTOs.Results;
using RegisterPersonAPI.Mappers.Interfaces;
using System.Net.Mime;
using System.Security.Claims;

namespace RegisterPersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class SettlementController : ControllerBase
    {
        private readonly ILogger<SettlementController> _logger;
        private readonly ISettlementMapper _mapper;
        private readonly ISettlementService _settlService;
        private readonly IPersonInformaitonService _personInfoService;

        public SettlementController(
            ILogger<SettlementController> logger,
            ISettlementMapper mapper,
            ISettlementService settlementService,
            IPersonInformaitonService personInfoService)
        {
            _logger = logger;
            _mapper = mapper;
            _settlService = settlementService;
            _personInfoService = personInfoService;
        }

        /// <summary>
        /// Get Settlement Information
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Settlement was sent</response>
        /// <response code="401">Unauthorized access</response>
        /// <response code="403">Forbidden attempt</response>
        /// <response code="404">Settlement not found</response>
        /// <response code="500">Server error</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(SettlementResultDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetSettlement()
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Get Settlement attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Forbidden attempt to GET Settlement for ID: {userNameIdentifier}.");
                return Forbid("Forbidden access.");
            }

            var dbSettlementInfo = _settlService.GetSettlement(userGuid);
            if (dbSettlementInfo == null)
            {
                _logger.LogWarning($"Settlement for {userNameIdentifier} not found.");
                return NotFound("Settlement not found.");
            }

            _logger.LogInformation($"Settlement successfully sent for user {userNameIdentifier}.");
            return Ok(_mapper.Map(dbSettlementInfo));
        }

        /// <summary>
        /// Create Settlement Information
        /// </summary>
        /// <param name="postDto"></param>
        /// <returns></returns>
        /// <response code="201">Settlement created</response>
        /// <response code="400">Settlement was created before</response>
        /// <response code="401">Unauthorized access</response>
        /// <response code="403">Forbidden attempt</response>
        /// <response code="404">Necessary Person Information was not found</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(SettlementResultDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostNewSettlement(SettlementRequestDto postDto)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Post Settlement attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Forbidden attempt to POST Settlement for ID: {userNameIdentifier}.");
                return Forbid("Forbidden access.");
            }

            var dbPersonInfo = _personInfoService.GetPersonalInformation(userGuid);

            if (dbPersonInfo == null)
            {
                _logger.LogWarning($"Information not found to complete POST Settlement {userNameIdentifier}.");
                return NotFound("Person Information not found.");
            }

            var entity = _mapper.Map(postDto, dbPersonInfo.Id);
            var dbSettlementInfo = _settlService.AddNewSettlement(entity, userGuid);

            if (dbSettlementInfo == 0)
            {
                _logger.LogWarning($"Settlement for {userNameIdentifier} is already created.");
                return BadRequest("Settlement was created before.");
            }

            _logger.LogInformation($"Settlement successfully created for {userNameIdentifier}.");
            return Created(nameof(GetSettlement), new { id = dbSettlementInfo });
        }

        /// <summary>
        /// Update Settlement
        /// </summary>
        /// <param name="postDto"></param>
        /// <returns></returns>
        /// <response code="204">Settlement updated</response>
        /// <response code="401">Unauthorized access</response>
        /// <response code="403">Forbidden attempt</response>
        /// <response code="404">Necessary Person Information was not found</response>
        /// <response code="500">Server error</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(SettlementResultDto), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateSettlement(SettlementRequestDto postDto)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Put Settlement attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Forbidden attempt to PUT Settlement of ID: {userNameIdentifier}.");
                return Forbid("Forbidden access.");
            }
            var dbPersonInfo = _personInfoService.GetPersonalInformation(userGuid);

            if (dbPersonInfo == null)
            {
                _logger.LogWarning($"Person Information for {userNameIdentifier} is not found.");
                return NotFound("Person Information was not found.");
            }

            var entity = _mapper.Map(postDto, dbPersonInfo.Id);
            var hasDbSettlementInfo = _settlService.UpdateSettlement(entity, userGuid);

            if (hasDbSettlementInfo == false)
            {
                _logger.LogWarning($"Settlement for {userNameIdentifier} is not found.");
                return NotFound("Settlement was not found.");
            }

            _logger.LogInformation($"Settlement successfully updated for {userNameIdentifier}.");
            return NoContent();
        }

    }
}
