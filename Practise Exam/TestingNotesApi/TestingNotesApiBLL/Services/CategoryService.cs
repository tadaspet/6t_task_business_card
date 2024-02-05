using TestingNotesApiBLL.Interfaces;
using TestingNotesDAL.Entities;
using TestingNotesDAL.Interfacees;

namespace TestingNotesApiBLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public int CreateNewCategory(NoteCategory newCategory)
        {
            var categoryId = _categoryRepository.SaveNewCategory(newCategory);
            return categoryId;
        }

        public List<NoteCategory> GetAllCategories(int userId)
        {
            return _categoryRepository.GetAllCategriesByUserId(userId);
        }
        public NoteCategory GetCategoryByIdAndUser(int id, int userId)
        {
            return _categoryRepository.GetCategoryByIdAndUser(id, userId);
        }
        public void DeleteCategoryById(int id)
        {
            _categoryRepository.DeleteCategory(id);
        }
        public bool UpdateCategory(NoteCategory newCategory)
        {
            var existingCategory = _categoryRepository.GetCategoryById(newCategory.Id);
            if (newCategory.UserId != existingCategory.UserId || existingCategory is null)
            {
                return false;
            }
            _categoryRepository.UpdateCategory(newCategory);
            return true;
        }
    }
}
