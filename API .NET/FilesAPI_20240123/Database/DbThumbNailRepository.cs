using FilesAPI_20240123.Models;

namespace FilesAPI_20240123.Database
{
    public class DbThumbNailRepository : IDbThumbNailRepository
    {
        private readonly FilesDbContext _dbContext;

        public DbThumbNailRepository(FilesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddThumbNail(ThumbNailImage thumbNail)
        {
            _dbContext.ThumbNailImages.Add(thumbNail);
            _dbContext.SaveChanges();
            return thumbNail.Id;
        }

        public void DeleteAddThumbNail(int id)
        {
            var thumbFile = _dbContext.ThumbNailImages.Find(id);
            if (thumbFile != null)
            {
                _dbContext.ThumbNailImages.Remove(thumbFile);
                _dbContext.SaveChanges();
            }
        }

        public ThumbNailImage GetAddThumbNail(int id)
        {
            return _dbContext.ThumbNailImages.Find(id);
        }

    }
}
