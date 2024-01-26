using _20240102_TASK_RepeatAPI.Respositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.Api.DTOs;

namespace _20240102_TASK_RepeatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRespository _respository;

        public ToDoController(IToDoRespository respository)
        {
            _respository = respository;
        }

        [HttpGet]
        public ActionResult<List<ToDoForCreateDto>> Get()
        {
            var todoList = _respository.GetAll();
            if(todoList == null)
            {
                return NotFound();
            }
            return Ok(todoList.Select(t => new ToDoForCreateDto(t)).ToList());
        }
        [HttpPost]
        public ActionResult Post(ToDoForCreateDto newItem)
        {
            var modelTodo = new ToDoForCreateDto().ToModelItem(newItem);
            _respository.Insert(modelTodo);
            if (modelTodo == null)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
