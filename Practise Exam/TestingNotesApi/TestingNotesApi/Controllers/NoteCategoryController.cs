using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;
using TestingNotesApi.DTOs;
using TestingNotesApi.Interfaces;
using TestingNotesApiBLL.Interfaces;

namespace TestingNotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class NoteCategoryController : ControllerBase
    {
        private readonly ICategoryMapper _categoryMapper;
        private readonly ICategoryService _categoryService;

        public NoteCategoryController(ICategoryMapper categoryMapper, ICategoryService categoryService)
        {
            _categoryMapper = categoryMapper;
            _categoryService = categoryService;
        }

        /// <summary>
        /// Find single Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="404">Data is not found</response>
        /// <response code="401">Data not accessable</response>
        /// <response code="200">Success, category found</response>
        [HttpGet("{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(NoteCategoryPushDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetCategoryById(int id)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var category = _categoryService.GetCategoryByIdAndUser(id, userId);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(_categoryMapper.Map(category));
        }

        /// <summary>
        /// Create New Category of the notes
        /// </summary>
        /// <param name="noteCategory"></param>
        /// <returns></returns>
        /// <response code="400">Data is not valid</response>
        /// <response code="401">Not accessable</response>
        /// <response code="201">Success, category added</response>
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateNoteCategory(NoteCategoryGetDTO noteCategory)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var entity = _categoryMapper.Map(noteCategory, userId);

            var newCategoryId = _categoryService.CreateNewCategory(entity);
            return Created(nameof(GetCategoryById), new { key = newCategoryId });
        }

        /// <summary>
        /// Update Category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noteCategory"></param>
        /// <returns></returns>
        /// <response code="404">Category not found</response>
        /// <response code="401">Not accessable</response>
        /// <response code="204">Category updated</response>
        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateNoteCategory(int id, NoteCategoryGetDTO noteCategory)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var entity = _categoryMapper.MapWithCategoryId(noteCategory, id, userId);
            var updateSuccess = _categoryService.UpdateCategory(entity);
            if (!updateSuccess)
            {
                return NotFound();
            }
            return NoContent();
        }

        /// <summary>
        /// Delete Category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="404">Category not found</response>
        /// <response code="401">Not accessable</response>
        /// <response code="204">Category deleted</response>
        [HttpDelete("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteNoteCategory(int id)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var existingCategory = _categoryService.GetCategoryByIdAndUser(id, userId);

            if (existingCategory is null)
            {
                return NotFound();
            }

            _categoryService.DeleteCategoryById(id);

            return NoContent();
        }

    }
}
