using TestingNotesApi.DTOs;
using TestingNotesApi.Interfaces;
using TestingNotesDAL.Entities;

namespace TestingNotesApi.Mappers
{
    public class CategoryMapper : ICategoryMapper
    {
        public NoteCategory Map(NoteCategoryGetDTO dto, int userId)
        {
            var noteCategory = new NoteCategory
            {
                Title = dto.Title,
                Description = dto.Description,
                UserId = userId,
            };
            return noteCategory;
        }
        public NoteCategory MapWithCategoryId(NoteCategoryGetDTO dto, int categoryId, int userId)
        {
            var noteCategory = new NoteCategory
            {
                Title = dto.Title,
                Description = dto.Description,
                Id = categoryId,
                UserId = userId,
            };
            return noteCategory;
        }
        public NoteCategoryPushDTO Map(NoteCategory model)
        {
            var dto = new NoteCategoryPushDTO
            {
                Title = model.Title,
                Description = model.Description,
                CreationDate = model.CreationDate,
                ModifiedDate = model.LastModifiedDate,
                Notes = model.Notes,
            };
            return dto;
        }
        public List<NoteCategoryPushDTO> Map(List<NoteCategory> models)
        {
            return models.Select(Map).ToList();
        }
    }
}
