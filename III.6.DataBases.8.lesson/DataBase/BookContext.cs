using III._6.DataBases._8.lesson.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III._6.DataBases._8.lesson.DataBase
{
    public class BookContext : DbContext
    {
        //public BookContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);  // galima istrinti

            // cia mes konfiguruojame sarysi daug su daug

            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    //.UseLazyLoadingProxies()
                    .UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=BookCategories;Trusted_Connection=True;MultipleActiveResultSets=true");

            }
            base.OnConfiguring(optionsBuilder);
            {

            }
        }
    }
}
