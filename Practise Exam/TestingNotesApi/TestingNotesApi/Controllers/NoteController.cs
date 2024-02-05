using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;
using TestingNotesApi.DTOs;
using TestingNotesApi.Interfaces;
using TestingNotesApi.Mappers;
using TestingNotesApiBLL.Interfaces;
using TestingNotesApiBLL.Services;
using TestingNotesDAL.Interfacees;

namespace TestingNotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class NoteController : ControllerBase
    {
        private readonly INoteMapper _noteMapper;
        private readonly INoteServices _notesService;
        private readonly ICategoryService _catService;

        public NoteController(INoteMapper noteMapper, INoteServices notesService, ICategoryService catService)
        {
            _noteMapper = noteMapper;
            _notesService = notesService;
            _catService = catService;
        }

        /// <summary>
        /// Find single Note
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
        public IActionResult GetNoteById(int id)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var note = _notesService.GetNoteByIdAndUser(id, userId);
            var category = _catService.GetCategoryByIdAndUser(note.NoteCategoryId, userId);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(_noteMapper.Map(note));
        }

        /// <summary>
        /// Creates New Note
        /// </summary>
        /// <param name="noteGetDTO"></param>
        /// <returns></returns>
        /// <response code="400">Data is not valid</response>
        /// <response code="401">Not accessable</response>
        /// <response code="201">Success, note created</response>
        [HttpPost]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateNote(NoteGetDTO noteGetDTO)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var matchUserAndCategory = _catService.GetCategoryByIdAndUser(noteGetDTO.NoteCategoryId, userId);

            if (matchUserAndCategory == null)
            {
                return ValidationProblem("Not found category");
            }
            var entity = _noteMapper.Map(noteGetDTO);

            var newNoteId = _notesService.CreateNewNote(entity);
            return Created(nameof(GetNoteById), new { key = newNoteId });
        }

        /// <summary>
        /// Change Note Category
        /// </summary>
        /// <param name="noteId"></param>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <response code="404">Note or Category were not found</response>
        /// <response code="401">Not accessable</response>
        /// <response code="400">Note is already in the same category</response>
        /// <response code="204">Category updated</response>
        [HttpPut("{noteId}/{categoryId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateNoteCategory(int noteId, int categoryId)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }

            var entityNote = _notesService.GetNoteByIdAndUser(noteId, userId);
            if (entityNote == null)
            {
                return ValidationProblem("Note was not found.");
            }

            var entityCategory = _catService.GetCategoryByIdAndUser(categoryId, userId);
            if (entityCategory == null)
            {
                return ValidationProblem("Category was not found.");
            }

            if(entityCategory.Id == categoryId)
            {
                return BadRequest("The note is already in the specified category.");
            }
            _ = _notesService.ChangeNoteCategory(entityNote, entityCategory.Id);

            return NoContent();
        }

        /// <summary>
        /// Update Note
        /// </summary>
        /// <param name="id"></param>
        /// <param name="noteDto"></param>
        /// <returns></returns>
        /// <response code="404">Note not found</response>
        /// <response code="401">Not accessable</response>
        /// <response code="204">Category updated</response>
        [HttpPut("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateNote(int id, NoteUpdateDTO noteDto)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var entityNote = _noteMapper.Map(id, noteDto);
            var isNoteUpdated = _notesService.UpdateNote(entityNote, userId);
            if (!isNoteUpdated)
            {
                return ValidationProblem("Note not found.");
            }
            return NoContent();
        }

        /// <summary>
        /// Delete Note
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="404">Note not found</response>
        /// <response code="401">Not accessable</response>
        /// <response code="204">Note deleted</response>
        [HttpDelete("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteNote(int id)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var existingNote = _notesService.GetNoteByIdAndUser(id, userId);

            if (existingNote is null)
            {
                return NotFound();
            }

            _notesService.DeleteNote(id);

            return NoContent();
        }

        /// <summary>
        /// Find Notes by Title
        /// </summary>
        /// <param name="searchName"></param>
        /// <returns></returns>
        /// <response code="404">Data is not found</response>
        /// <response code="401">Data not accessable</response>
        /// <response code="200">Success, notes were found</response>
        [HttpGet("search/{searchName}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(NoteCategoryPushDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetNoteSearchByTitle(string searchName)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var notes = _notesService.GetNoteSearchByTitle(searchName, userId);

            if (notes.Count() == 0)
            {
                return NotFound("No results by Title search.");
            }
            return Ok(_noteMapper.Map(notes));
        }

        /// <summary>
        /// Filter Notes by Category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        /// <response code="404">Data is not found</response>
        /// <response code="401">Data not accessable</response>
        /// <response code="200">Success, notes were found</response>
        [HttpGet("filterBy/{categoryId}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(NoteCategoryPushDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetNoteSearchByTitle(int categoryId)
        {
            var userNameIdentifier = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userNameIdentifier, out var userId))
            {
                return Unauthorized();
            }
            var notes = _notesService.GetNotesByCategoryId(categoryId, userId);

            if (notes.Count() == 0)
            {
                return NotFound($"No results in the category {categoryId}.");
            }
            return Ok(_noteMapper.Map(notes));
        }
    }
}
