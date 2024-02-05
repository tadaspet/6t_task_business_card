using Microsoft.EntityFrameworkCore;
using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.ApiDbContext
{
    public class RegisterDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<PersonInformation> PersonInformations { get; set; }
        public DbSet<Settlement> Settlements { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public RegisterDbContext(DbContextOptions<RegisterDbContext> options) : base(options)
        {

        }

    }
}
