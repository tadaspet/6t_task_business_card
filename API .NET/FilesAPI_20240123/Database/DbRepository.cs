using FilesAPI_20240123.Models;

namespace FilesAPI_20240123.Database
{
    public class DbRepository : IDbRepository
    {
        private readonly FilesDbContext _dbContext;

        public DbRepository(FilesDbContext dbContext)
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
