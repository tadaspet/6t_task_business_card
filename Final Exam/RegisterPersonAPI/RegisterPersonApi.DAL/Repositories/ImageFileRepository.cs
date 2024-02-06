using Microsoft.EntityFrameworkCore;
using RegisterPersonApi.DAL.ApiDbContext;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.DAL.Repositories
{
    public class ImageFileRepository : IImageFileRepository
    {
        private readonly RegisterDbContext _context;

        public ImageFileRepository(RegisterDbContext context)
        {
            _context = context;
        }

        public ImageFile GetImageFile(Guid userId)
        {
            var imageFileInfo = _context.ImageFiles
                .Include(p => p.PersonInformation)
                .ThenInclude(u => u.User)
                .Where(x => x.PersonInformation.User.Id == userId)
                .FirstOrDefault();
            if (imageFileInfo == null)
            {
                return null;
            }
            return imageFileInfo;
        }

        public int AddImageFile(ImageFile imageFile)
        {
            _context.ImageFiles.Add(imageFile);
            _context.SaveChanges();
            return imageFile.Id;
        }

        public bool DeleteImageFile(int id)
        {
            var imageFile = _context.ImageFiles.Find(id);
            if (imageFile != null)
            {
                _context.ImageFiles.Remove(imageFile);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
