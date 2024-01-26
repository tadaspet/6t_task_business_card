using Paksita14_16012024.Models;

namespace Paksita14_16012024.BussinessLogic
{
    public interface IShoppingListService
    {
        /// <summary>
        /// Inserts shoppping list to database
        /// </summary>
        /// <param name="shoppingList">Shoppping list to create</param>
        /// <returns>Inserted shoppping list Id</returns>
        int CreateShoppingList(ShoppingList shoppingList);
        ShoppingList GetShoppingListForUserByID(int id, int userId);
        List<ShoppingList> GetUserShoppingLists(int userId);
        void UpdateShoppingListForUser(ShoppingList shoppingList, int userId);
        void DeleteShoppingListForUser(int id,int  userId);

    }
}
