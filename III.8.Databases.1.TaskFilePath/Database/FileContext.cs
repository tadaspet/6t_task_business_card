using Azure;
using III._8.Databases._1.TaskFilePath.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III._8.Databases._1.TaskFilePath.Database
{
    public class FileContext : DbContext
    {
        public DbSet<Models.File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;" + //server adress
                $"Database=FileReadApplication;" + //sql server database
                $"Trusted_Connection=True;"); //connection credentials type
    }
}
