using KeepNotesDAL.Entities;
using Microsoft.EntityFrameworkCore;
using TestingNotesDAL.Entities;

namespace KeepNotesDAL.AppDbContext
{
    public class NotesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<NoteCategory> NoteCategories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
        {

        }
    }
}
