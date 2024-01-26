using Microsoft.EntityFrameworkCore;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.DataLayer
{
    public class ShoppingListDbContex : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }

        public ShoppingListDbContex(DbContextOptions<ShoppingListDbContex> options) : base(options) 
        {
            
        }
    }
}
