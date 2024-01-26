using FilesAPI_20240123.Models;
using PhotoApi.DAL.ApiDbContext;
using PhotoApi.DAL.Interfaces;

namespace FilesAPI_20240123.Database
{
    public class DbThumbNailRepository : IDbThumbNailRepository
    {
        private readonly PhotoDbContext _dbContext;

        public DbThumbNailRepository(PhotoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddThumbNail(ThumbNailImage thumbNail)
        {
            _dbContext.Thumbs.Add(thumbNail);
            _dbContext.SaveChanges();
            return thumbNail.Id;
        }

        public void DeleteAddThumbNail(int id)
        {
            var thumbFile = _dbContext.Thumbs.Find(id);
            if (thumbFile != null)
            {
                _dbContext.Thumbs.Remove(thumbFile);
                _dbContext.SaveChanges();
            }
        }

        public ThumbNailImage GetAddThumbNail(int id)
        {
            return _dbContext.Thumbs.Find(id);
        }

    }
}
