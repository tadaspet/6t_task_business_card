﻿using _2._2012.IntroductionAPI.DataLayer.Models;
using System.ComponentModel.DataAnnotations;
using _2._2012.IntroductionAPI.Attributes;

namespace _2._2012.IntroductionAPI.Dtos
{
    public class CreateToDoItemDto
    {
        /// <summary>
        /// Type of todo Item. COuld be work
        /// </summary>
        [Required]
        [ValidTodoType(ErrorMessage = "Type is not in the possible range.")]
        public string Type { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Content { get; set; }
        //[RegularExpression(@"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}\.\d{3}Z$", ErrorMessage = "Date must be in YYYY-MM-DD format")]
        [NoWeekEnds]
        public DateTime? EndDate { get; set; }
        [Required]
        [StringLength(20)]
        public string UserId { get; set; }

        //public static explicit operator TodoItem(GetTodoItemDto dto)
        //{
        //    return new TodoItem
        //    {
        //        Content = dto.Content,
        //        Type = dto.Type,
        //        EndDate = dto.EndDate,
        //        UserId = dto.UserId
        //    };
        //}

        public static TodoItem ToModel(CreateToDoItemDto dto)
        {
            return new TodoItem
            {
                Content = dto.Content,
                Type = dto.Type,
                EndDate = dto.EndDate,
                UserId = dto.UserId
            };
        }

    }
}
