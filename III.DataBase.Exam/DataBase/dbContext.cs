using III.DataBase.Exam.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace III.DataBase.Exam
{
    public class dbContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        //public DbSet<FacultyCourse> FacultyCourses { get; set; }
 
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FacultyCourse>()
        //        .HasKey(fc => new { fc.FacultyId, fc.CourseId });

        //    modelBuilder.Entity<FacultyCourse>()
        //        .HasOne(f => f.Faculty)
        //        .WithMany(fc => fc.FacultyCourses)
        //        .HasForeignKey(f => f.FacultyId);

        //    modelBuilder.Entity<FacultyCourse>()
        //        .HasOne(c => c.Course)
        //        .WithMany(fc => fc.FacultyCourses)
        //        .HasForeignKey(c => c.CourseId);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;" + //server adress
            $"Database=StudentInformationSystem;" + //sql server database
            $"Trusted_Connection=True;"); //connection credentials type
    }
}