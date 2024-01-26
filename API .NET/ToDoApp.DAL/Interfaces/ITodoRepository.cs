using ToDoApp.DAL.Entities;

namespace ToDoApp.DAL.Interfaces
{
    public interface ITodoRepository
    {
        void Add(TodoItem item);
        IList<TodoItem> All();
        TodoItem Get(int id);
        public void Update(TodoItem item);
        public void Delete(TodoItem item);
    }
}
