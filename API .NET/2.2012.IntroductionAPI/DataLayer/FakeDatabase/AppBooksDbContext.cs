using _2._2012.IntroductionAPI.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace _2._2012.IntroductionAPI.DataLayer.FakeDatabase
{
    public class AppBooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        public AppBooksDbContext(DbContextOptions<AppBooksDbContext> options) : base(options)
        {
        }
    }
}
