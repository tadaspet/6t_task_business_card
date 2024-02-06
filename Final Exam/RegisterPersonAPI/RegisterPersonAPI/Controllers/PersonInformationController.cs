using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RegisterPersonApi.BLL.Services;
using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Dtos.Results;
using RegisterPersonAPI.Mappers.Interfaces;
using System.Net.Mime;
using System.Security.Claims;

namespace RegisterPersonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class PersonInformationController : ControllerBase
    {
        private readonly ILogger<PersonInformationController> _logger;
        private readonly IPersonInfoMapper _mapper;
        private readonly IPersonInformaitonService _personService;        
        private readonly IImageFileRepository _imageFileRepository;
        private readonly IImageFileMapper _imageFileMapper;

        public PersonInformationController(
            ILogger<PersonInformationController> logger,
            IPersonInfoMapper mapper,
            IPersonInformaitonService personService,
            IImageFileRepository imageFileRepository,
            IImageFileMapper imageFileMapper)
        {
            _logger = logger;
            _mapper = mapper;
            _personService = personService;
            _imageFileRepository = imageFileRepository;
            _imageFileMapper = imageFileMapper;
        }

        /// <summary>
        /// Get Person Information
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Person Information sent</response>
        /// <response code="401">Unauthorised access</response>
        /// <response code="403">Forbidden atempt</response>
        /// <response code="404">Person Information not found</response>
        /// <response code="500">Server error</response>
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(PersonInfoResultDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetPersonInformation()
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Get Person Information attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Unauthorised attempt to GET Person Information {userNameIdentifier}.");
                return Forbid("Unauthorised access.");
            }

            var dbPersonInfo = _personService.GetPersonalInformation(userGuid);

            if (dbPersonInfo == null)
            {
                _logger.LogWarning($"Person Information for {userNameIdentifier} not found.");
                return NotFound("Not found information.");
            }

            _logger.LogInformation($"Person Information successfully sent for user {userNameIdentifier}.");
            return Ok(_mapper.Map(dbPersonInfo));
        }

        /// <summary>
        /// Create Person Information
        /// </summary>
        /// <param name="postDto"></param>
        /// <returns></returns>
        /// <response code="201">Person Information created</response>
        /// <response code="400">Person Information was created before</response>
        /// <response code="401">Unauthorised access</response>
        /// <response code="403">Forbidden atempt</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(PersonInfoResultDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostNewPersonInformation(PersonInfoRequestDto postDto)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Post Person Information attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Unauthorised attempt to POST Person Information {userNameIdentifier}.");
                return Forbid("Unauthorised access.");
            }

            var entity = _mapper.Map(postDto, userGuid);
            var dbPersonInfo = _personService.AddNewPersonInformation(entity);

            if (dbPersonInfo == 0)
            {
                _logger.LogWarning($"Person Information for {userNameIdentifier} is already created.");
                return BadRequest("Person Information was created before.");
            }

            _logger.LogInformation($"Person Information successfully created for {userNameIdentifier}.");
            return Created(nameof(GetPersonInformation), new { id = dbPersonInfo });
        }

        /// <summary>
        /// Update Person Information
        /// </summary>
        /// <param name="postDto"></param>
        /// <returns></returns>
        /// <response code="204">Person Information updated</response>
        /// <response code="404">Person Information was not found</response>
        /// <response code="401">Unauthorised access</response>
        /// <response code="403">Forbidden atempt</response>
        /// <response code="500">Server error</response>
        [HttpPut]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(PersonInfoResultDto), StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePersonInformation(PersonInfoRequestDto postDto)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Put Person Information attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Unauthorised attempt to PUT Person Information of {userNameIdentifier}.");
                return Forbid("Unauthorised access.");
            }

            var entity = _mapper.Map(postDto, userGuid);
            var dbPersonInfo = _personService.UpdatePersonInformaiton(entity);

            if (dbPersonInfo == false)
            {
                _logger.LogWarning($"Person Information for {userNameIdentifier} is not found.");
                return NotFound("Person Information was not found.");
            }

            _logger.LogInformation($"Person Information successfully updated for {userNameIdentifier}.");
            return NoContent();
        }

        /// <summary>
        /// Upload Image File
        /// </summary>
        /// <param name="postDto"></param>
        /// <returns></returns>
        /// <response code="201">Image File uploaded</response>
        /// <response code="400">Image File could not be saved</response>
        /// <response code="401">Unauthorised access</response>
        /// <response code="403">Forbidden atempt</response>
        /// <response code="500">Server error</response>
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ImageFileRequestDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UploadNewImageFile(ImageFileRequestDto postDto)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Post Image File attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Unauthorised attempt to POST Image File {userNameIdentifier}.");
                return Forbid("Unauthorised access.");
            }

            var dbPersonInfo = _personService.GetPersonalInformation(userGuid);

            if (dbPersonInfo == null)
            {
                _logger.LogWarning($"Person Information has not been found for {userNameIdentifier}.");
                return NotFound("Person Information has not been found.");
            }

            var entity = _imageFileMapper.Map(postDto, dbPersonInfo.Id);
            var dbImageId = _imageFileRepository.AddImageFile(entity);

            if (dbImageId == 0)
            {
                _logger.LogWarning($"Image File for {userNameIdentifier} upload failed.");
                return BadRequest("Image File could not be saved.");
            }

            _logger.LogInformation($"Image File successfully uploaded for {userNameIdentifier}.");
            return Created(nameof(GetPersonInformation), new { id = dbPersonInfo });
        }

        [HttpGet("downloadImage")]
        public IActionResult DownLoad()
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"GET Image File attempt for {userNameIdentifier}.");

            var checkGuid = Guid.TryParse(userNameIdentifier, out var userGuid);

            if (!checkGuid)
            {
                _logger.LogWarning($"Unauthorised attempt to GET Image File {userNameIdentifier}.");
                return Forbid("Unauthorised access.");
            }

            var imageFile = _imageFileRepository.GetImageFile(userGuid);
            if (imageFile == null)
            {
                return NotFound();
            }

            return File(imageFile.Content, imageFile.ContentType, imageFile.FileName);
        }
    }
}
