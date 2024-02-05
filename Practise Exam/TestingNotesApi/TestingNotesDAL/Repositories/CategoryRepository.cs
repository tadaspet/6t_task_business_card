using KeepNotesDAL.AppDbContext;
using Microsoft.EntityFrameworkCore;
using TestingNotesDAL.Entities;
using TestingNotesDAL.Interfacees;

namespace TestingNotesDAL.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NotesDbContext _context;

        public CategoryRepository(NotesDbContext context)
        {
            _context = context;
        }

        public int SaveNewCategory(NoteCategory newCategory)
        {
            var user = _context.Users.Find(newCategory.UserId);
            newCategory.User = user;
            newCategory.CreationDate = DateTime.Now;

            _context.NoteCategories.Add(newCategory);
            _context.SaveChanges();

            return newCategory.Id;
        }
        public List<NoteCategory> GetAllCategriesByUserId(int userId)
        {
            return _context.NoteCategories.Include(n => n.Notes).Where(u => u.UserId == userId).ToList();
        }

        public NoteCategory GetCategoryByIdAndUser(int categoryId, int userId)
        {
            var category = _context.NoteCategories.FirstOrDefault(c => c.Id == categoryId);
            if (category is null || category.UserId != userId)
            {
                return null;
            }
            return category;
        }
        public NoteCategory GetCategoryById(int categoryId)
        {
            var category = _context.NoteCategories.FirstOrDefault(c => c.Id == categoryId);
            if (category is null)
            {
                return null;
            }
            return category;
        }

        public bool DeleteCategory(int id)
        {
            var category = _context.NoteCategories.Find(id);
            if (category is null)
            {
                return false;
            }
            _context.NoteCategories.Remove(category);
            _context.SaveChanges();
            return true;
        }

        public void UpdateCategory(NoteCategory noteCategory)
        {
            var category = _context.NoteCategories.FirstOrDefault(c => c.Id == noteCategory.Id);
            category.Title = noteCategory.Title;
            category.Description = noteCategory.Description;
            category.LastModifiedDate = DateTime.Now;
            _context.NoteCategories.Update(category);
            _context.SaveChanges();

        }
    }
}
