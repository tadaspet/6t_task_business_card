using ToDoApp.DAL.Entities;
using ToDoApp.DAL.Interfaces;

namespace ToDoApp.DAL.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public TodoRepository() { }
        public IList<TodoItem> All()
        {
            throw new NotImplementedException();
        }
        public TodoItem Get(int id)
        {
            throw new NotImplementedException();
        }
        public void Add(TodoItem item)
        {
            throw new NotImplementedException();
        }
        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
        public void Delete(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
