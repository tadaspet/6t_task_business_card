using FilesAPI_20240123.Models;
using Microsoft.EntityFrameworkCore;

namespace FilesAPI_20240123.Database
{
    public class FilesDbContext :DbContext
    {
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<ThumbNailImage> ThumbNailImages { get; set; }
        public FilesDbContext(DbContextOptions<FilesDbContext> options) : base(options) 
        {

        }



    }
}
