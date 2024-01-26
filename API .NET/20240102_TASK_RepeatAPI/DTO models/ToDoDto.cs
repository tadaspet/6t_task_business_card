using _20240102_TASK_RepeatAPI.Models;

namespace ToDo.Api.DTOs
{
    public class ToDoDto : ToDoForCreateDto
    {
        public int Id { get; set; }

        public ToDoDto()
        {

        }

        public ToDoDto(ToDoItem item) : base(item)
        {
            Id = item.Id;
        }
    }
}
