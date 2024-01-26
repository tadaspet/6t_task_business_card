using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMultiprojectWithDbAccessLayer
{
    public class MultiProjectDbContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public MultiProjectDbContext(DbContextOptions<MultiProjectDbContext> options) : base(options) 
        {
        }


    }
}
