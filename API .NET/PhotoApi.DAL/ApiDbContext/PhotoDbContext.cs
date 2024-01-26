using FilesAPI_20240123.Models;
using Microsoft.EntityFrameworkCore;

namespace PhotoApi.DAL.ApiDbContext
{
    public class PhotoDbContext : DbContext
    {
        public PhotoDbContext(DbContextOptions<PhotoDbContext> options) : base(options)
        {

        }

        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<ThumbNailImage> Thumbs { get; set; }

    }
}
