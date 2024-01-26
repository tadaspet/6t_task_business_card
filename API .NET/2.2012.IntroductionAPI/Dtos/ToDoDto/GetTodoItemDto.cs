﻿using _2._2012.IntroductionAPI.DataLayer.Models;

namespace _2._2012.IntroductionAPI.Dtos.ToDoDto
{
    public class GetTodoItemDto
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserId { get; set; }

        public GetTodoItemDto(TodoItem model)
        {
            Id = model.Id;
            Type = model.Type;
            Content = model.Content;
            EndDate = model.EndDate;
            UserId = model.UserId;
        }
    }
}
