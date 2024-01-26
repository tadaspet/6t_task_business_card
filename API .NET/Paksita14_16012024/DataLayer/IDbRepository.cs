using Paksita14_16012024.Models;

namespace Paksita14_16012024.DataLayer
{
    public interface IDbRepository
    {
        /// <summary>
        /// Inserts shopping List to database
        /// </summary>
        /// <param name="shoppingList">Shopping list to create</param>
        /// <returns>Inserted Shopping List ID</returns>
        int CreateShoppingList(ShoppingList shoppingList);
        ShoppingList GetShoppingListByID(int shoppingId);
        List<ShoppingList> GetShoppingListByUserId(int userId);
        void UpdateShoppingList(ShoppingList shoppingList);
        void DeleteShoppingList(int shoppingId);
    }
}
