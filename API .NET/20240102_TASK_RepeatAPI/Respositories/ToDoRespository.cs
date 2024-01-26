using _20240102_TASK_RepeatAPI.DataBase;
using _20240102_TASK_RepeatAPI.Models;

namespace _20240102_TASK_RepeatAPI.Respositories
{
    public class ToDoRespository : IToDoRespository
    {
        private readonly ApplicationToDoDBContext _applicationToDoDBContext;


        public ToDoRespository(ApplicationToDoDBContext applicationToDoDBContext)
        {
            _applicationToDoDBContext = applicationToDoDBContext;
        }

        public List<ToDoItem> GetAll()
        {
            var modelBooks = _applicationToDoDBContext.TodoItems.ToList();
            return modelBooks;
        }
        public ToDoItem Get(int key)
        {
            var bookByID = _applicationToDoDBContext.TodoItems.FirstOrDefault(x => x.Id == key);
            return bookByID;
        }
        public ToDoItem Insert(ToDoItem item)
        {
            _applicationToDoDBContext.TodoItems.Add(item);
            _applicationToDoDBContext.SaveChanges();
            return _applicationToDoDBContext.TodoItems.FirstOrDefault(t => t.Id == item.Id);
        }
    }

    public interface IToDoRespository
    {
        ToDoItem Get(int key);
        List<ToDoItem> GetAll();
        ToDoItem Insert(ToDoItem item);
    }
}
