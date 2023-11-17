using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    public class AccountDataBase : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;" + //server adress
                $"Database=AccountInformation;" + //sql server database
                $"Trusted_Connection=True;"); //connection credentials type
    }
}
