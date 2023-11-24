using Microsoft.EntityFrameworkCore;
using PersonelSystem.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem.DataBase
{
    public class DepartContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<DepartmentProject> DepartmentProjects { get; set; }
        public DbSet<EmployyeProject> EmployyeProjects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;" + //server adress
                $"Database=Personel;" + //sql server database
                $"Trusted_Connection=True;"); //connection credentials type

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentProject>()
                .HasKey(dp => new { dp.DepartmentId, dp.ProjectId});

            modelBuilder.Entity<DepartmentProject>()
                .HasOne(dp => dp.Department)
                .WithMany(dp => dp.DepartmentProjects)
                .HasForeignKey(dp => dp.DepartmentId);

            modelBuilder.Entity<DepartmentProject>()
                .HasOne(p => p.Project)
                .WithMany(d => d.DepartmentProjects)
                .HasForeignKey(p => p.ProjectId);

            modelBuilder.Entity<EmployyeProject>()
                .HasKey(dp => new { dp.EmployeeId, dp.ProjectId });

            modelBuilder.Entity<EmployyeProject>()
                .HasOne(e => e.Employee)
                .WithMany(e => e.EmployyeProjects)
                .HasForeignKey(d => d.EmployeeId);

            modelBuilder.Entity<EmployyeProject>()
                .HasOne(e => e.Project)
                .WithMany(e => e.EmployyeProjects)
                .HasForeignKey(d => d.ProjectId);

        }
    }
}
