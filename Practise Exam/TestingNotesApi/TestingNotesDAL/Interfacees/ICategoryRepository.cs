using TestingNotesDAL.Entities;

namespace TestingNotesDAL.Interfacees
{
    public interface ICategoryRepository
    {
        bool DeleteCategory(int id);
        NoteCategory GetCategoryById(int categoryId);
        public NoteCategory GetCategoryByIdAndUser(int categoryId, int userId);
        List<NoteCategory> GetAllCategriesByUserId(int userId);
        public int SaveNewCategory(NoteCategory newCategory);
        public void UpdateCategory(NoteCategory noteCategory);
    }
}