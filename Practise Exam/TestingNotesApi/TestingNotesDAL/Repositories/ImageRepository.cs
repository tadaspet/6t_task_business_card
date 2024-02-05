using KeepNotesDAL.AppDbContext;
using KeepNotesDAL.Entities;
using Microsoft.EntityFrameworkCore;
using TestingNotesDAL.Entities;
using TestingNotesDAL.Interfacees;

namespace KeepNotesDAL.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly NotesDbContext _dbContext;

        public ImageRepository(NotesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddImageFile(ImageFile imageFile)
        {
            _dbContext.ImageFiles.Add(imageFile);
            _dbContext.SaveChanges();
            return imageFile.Id;
        }

        public void DeleteImageFile(int id)
        {
            var imageFile = _dbContext.ImageFiles.Find(id);
            if (imageFile != null)
            {
                _dbContext.ImageFiles.Remove(imageFile);
                _dbContext.SaveChanges();
            }
        }

        public ImageFile GetImageFile(int id)
        {
            return _dbContext.ImageFiles.Find(id);
        }

        public ImageFile GetByImageIdAndUser(int imageId, int userId)
        {
            var image = _dbContext.ImageFiles
                .Include(n => n.Note)
                .ThenInclude(c => c.NoteCategory)
                .ThenInclude(c => c.User)
                .FirstOrDefault(n => n.Id == imageId && n.Note.NoteCategory.UserId == userId);

            if (image == null)
            {
                return null;
            }
            var imageUserId = _dbContext.ImageFiles
                .Where(n => n.Id == image.Id)
                .Select(n => n.Note.NoteCategory.UserId)
                .FirstOrDefault();

            if (imageUserId != userId)
            {
                return null;
            }
            return image;
        }
    }
}
