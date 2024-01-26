using Microsoft.EntityFrameworkCore;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.DataLayer
{
    public class DbRepository : IDbRepository
    {
        private readonly ShoppingListDbContex _shoppingListDbContext;

        public DbRepository(ShoppingListDbContex dbContext)
        {
            _shoppingListDbContext = dbContext;
        }

        public int CreateShoppingList(ShoppingList shoppingList)
        {
            _shoppingListDbContext.ShoppingLists.Add(shoppingList); 
            _shoppingListDbContext.SaveChanges();
            return shoppingList.Id;
        }

        public void DeleteShoppingList(int shoppingId)
        {
            var shoppingList = _shoppingListDbContext.ShoppingLists.Find(shoppingId);
            _shoppingListDbContext.ShoppingLists.Remove(shoppingList);

            //efektyvesnis budas
            //var shoppingList = new ShoppingList() { Id = shoppingId };
            //_shoppingListDbContext.ShoppingLists.Attach(shoppingList);
            //_shoppingListDbContext.ShoppingLists.Remove(shoppingList);

            _shoppingListDbContext.SaveChanges();
        }

        public ShoppingList GetShoppingListByID(int shoppingId)
        {
            return _shoppingListDbContext.ShoppingLists.Include(s => s.Items).FirstOrDefault(x => x.Id == shoppingId);
        }

        public List<ShoppingList> GetShoppingListByUserId(int userId)
        {
            return _shoppingListDbContext.ShoppingLists.Include( s => s.Items).Where( x => x.UserId == userId ).ToList();
        }

        public void UpdateShoppingList(ShoppingList shoppingList)
        {
            _shoppingListDbContext.ShoppingLists.Update(shoppingList);
            _shoppingListDbContext.SaveChanges();
        }
    }
}
