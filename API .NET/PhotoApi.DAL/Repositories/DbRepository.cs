using FilesAPI_20240123.Models;
using PhotoApi.DAL.ApiDbContext;
using PhotoApi.DAL.Interfaces;

namespace FilesAPI_20240123.Database
{
    public class DbRepository : IDbRepository
    {
        private readonly PhotoDbContext _dbContext;

        public DbRepository(PhotoDbContext dbContext)
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
            if(imageFile != null)
            {
                _dbContext.ImageFiles.Remove(imageFile);
                _dbContext.SaveChanges();
            }
        }

        public ImageFile GetImageFile(int id)
        {
            return _dbContext.ImageFiles.Find(id);
        }
    }
}
