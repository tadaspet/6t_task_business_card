using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2._2012.IntroductionAPI.DataLayer.FakeDatabase;
using _2._2012.IntroductionAPI.DataLayer.Models;
using _2._2012.IntroductionAPI.Dtos;
using _2._2012.IntroductionAPI.DataLayer.Repositories;

namespace _2._2012.IntroductionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        public readonly ITodoRepository database;

        public ToDoController(ITodoRepository database)
        {
            this.database = database;
        }

        [HttpGet]
        public IEnumerable<GetTodoItemDto> GetAll()
        {
            var data = database.GetAll();
            return data.Select(t => new GetTodoItemDto(t));
        }

        [HttpGet("{key}")]
        public GetTodoItemDto GetByID(int key)
        {
            var data = database.GetByID(key);
            return new GetTodoItemDto(data);
        }








        //front-end (javascript fetch, dirba su DTO) -->
        //controller (gauna dto ir is dto daro modeli) ->
        //repositori(model) ->
        //database




        //[HttpGet("filterBy/{typeName}")]
        //public IEnumerable<TodoItem> GetAllFilteredByType(string typeName)
        //{
        //    var database = new FakeDataBase();
        //    var data = database.GetAll().Where(t => t.Type == typeName);
        //    return data;
        //}

        //[HttpDelete]
        //public void Delete(int id)
        //{
        //    var database = new FakeDataBase();
        //    database.RemoveToDoItem(id);
        //}
        //[HttpPost]
        //public void CreateTodo(TodoItem todo)
        //{
        //    var database = new FakeDataBase();
        //    database.CreateToDoItem(todo);
        //}
        //[HttpPut()]
        //public void UpdateTodo(TodoItem todo)
        //{
        //    var database = new FakeDataBase();
        //    database.UpdateTodo(todo);
        //}

    }
}
 