using Microsoft.EntityFrameworkCore;
using NoteKeeper.Api.DAL.Entities;

namespace NoteKeeper.Api.DAL.ApiDbContext
{
    public class ApiDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
