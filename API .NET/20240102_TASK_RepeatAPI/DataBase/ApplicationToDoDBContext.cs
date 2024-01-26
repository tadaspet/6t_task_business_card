using _20240102_TASK_RepeatAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace _20240102_TASK_RepeatAPI.DataBase
{
    public class ApplicationToDoDBContext : DbContext
    {
        public DbSet<ToDoItem> TodoItems { get; set; }
        public ApplicationToDoDBContext(DbContextOptions<ApplicationToDoDBContext> options) : base(options) { }
    }
}
