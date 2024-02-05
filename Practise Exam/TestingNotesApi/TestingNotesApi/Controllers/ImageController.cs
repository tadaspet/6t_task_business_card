using KeepNotesApiBLL.Services;
using KeepNotesDAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;
using TestingNotesApi.Api.DTOs;
using TestingNotesApi.DTOs;
using TestingNotesApi.Interfaces;
using TestingNotesApi.Mappers;
using TestingNotesApiBLL.Interfaces;

namespace TestingNotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class ImageController : ControllerBase
    {
        private readonly IImageFileMapper _imageFileMapper;
        private readonly IImageFilesServices _imageFilesServices;
        private readonly INoteServices _noteServices;

        public ImageController(IImageFileMapper imageFileMapper, IImageFilesServices imageFilesServices, INoteServices noteServices)
        {
            _imageFileMapper = imageFileMapper;
            _imageFilesServices = imageFilesServices;
            _noteServices = noteServices;
        }

        /// <summary>
        /// Upload Image for Note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="404">Data is not found</response>
        /// <response code="401">Data not accessable</response>
        /// <response code="200">Success, note found</response>
        [HttpPost("upload/{noteId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(NoteCategoryPushDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Upload(int noteId, ImageUploadRequest request)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var noetBelongsToUser = _noteServices.GetNoteByIdAndUser(noteId, userId);
            if (noetBelongsToUser is null)
            {
                return ValidationProblem($"User does not have access for note {noteId}.");
            }

            var imageFile = _imageFileMapper.Map(noteId, request);
            var imageAnswer = _imageFilesServices.AddImageFile(imageFile);

            return Ok(imageAnswer);
        }

        /// <summary>
        /// DownLoad Image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="404">Data is not found</response>
        /// <response code="401">Data not accessable</response>
        /// <response code="200">Success, note found</response>
        [HttpGet("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(NoteCategoryPushDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetImageId(int id)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }

            var imageExists = _imageFilesServices.GetByImageIdAndUser(id, userId);

            if (imageExists == null)
            {
                return ValidationProblem($"User does not have image {id}.");
            }
            return File(imageExists.Content, imageExists.ContentType, imageExists.FileName);
        }

    }
}
