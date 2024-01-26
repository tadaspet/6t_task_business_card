using Microsoft.AspNetCore.Identity;

namespace _20240102_TASK_RepeatAPI.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserId { get; set; }
        public IdentityUser? User { get; set; }
    }
}
