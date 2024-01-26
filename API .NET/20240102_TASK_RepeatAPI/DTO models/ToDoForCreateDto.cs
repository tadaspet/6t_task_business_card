using _20240102_TASK_RepeatAPI.Models;

namespace ToDo.Api.DTOs
{
    public class ToDoForCreateDto
    {
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime? EndDate { get; set; }

        public ToDoForCreateDto()
        {

        }

        public ToDoForCreateDto(ToDoItem item)
        {
            UserId = item.UserId;
            Type = item.Type;
            Content = item.Content;
            EndDate = item.EndDate;
        }
        public ToDoItem ToModelItem(ToDoForCreateDto dto)
        {
            return new ToDoItem()
            {
                UserId = dto.UserId,
                Type = dto.Type,
                Content = dto.Content,
                EndDate = dto.EndDate,
            }; 
        }
    }
}
