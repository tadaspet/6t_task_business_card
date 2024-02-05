using TestingNotesApi.DTOs;
using TestingNotesDAL.Entities;

namespace TestingNotesApi.Interfaces
{
    public interface ICategoryMapper
    {
        public NoteCategory Map(NoteCategoryGetDTO dto, int userId);
        NoteCategoryPushDTO Map(NoteCategory model);
        List<NoteCategoryPushDTO> Map(List<NoteCategory> models);
        public NoteCategory MapWithCategoryId(NoteCategoryGetDTO dto, int categoryId, int userId);
    }
}