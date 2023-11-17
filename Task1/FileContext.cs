using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileContext : DbContext
    {
        public DbSet<File> Files { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;" + //server adress
                $"Database=1FileInfo;" + //sql server database
                $"Trusted_Connection=True;"); //connection credentials type
    }
}
