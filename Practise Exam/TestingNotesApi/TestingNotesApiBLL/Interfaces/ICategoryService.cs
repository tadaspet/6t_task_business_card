using TestingNotesDAL.Entities;

namespace TestingNotesApiBLL.Interfaces
{
    public interface ICategoryService
    {
        int CreateNewCategory(NoteCategory newCategory);
        void DeleteCategoryById(int id);
        List<NoteCategory> GetAllCategories(int userId);
        public NoteCategory GetCategoryByIdAndUser(int id, int userId);
        public bool UpdateCategory(NoteCategory newCategory);
    }
}