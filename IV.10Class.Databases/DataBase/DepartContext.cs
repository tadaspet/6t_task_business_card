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
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;" + //server adress
                $"Database=Personel;" + //sql server database
                $"Trusted_Connection=True;"); //connection credentials type
    }
}
