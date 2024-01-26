using Paksita14_16012024.DataLayer;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.BussinessLogic
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly IDbRepository _dbRepository;

        public ShoppingListService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public int CreateShoppingList(ShoppingList shoppingList)
        {
            return _dbRepository.CreateShoppingList(shoppingList);
        }

        public void DeleteShoppingListForUser(int id, int userId)
        {
            var shopppingList = _dbRepository.GetShoppingListByID(id);
            if(shopppingList == null)
            {
                throw new Exception("Shopping list not found");
            }
            if(shopppingList.UserId != userId) 
            {
                throw new Exception("User is trying to delete foreign shopping list");
            }
            _dbRepository.DeleteShoppingList(id);
        }

        public ShoppingList GetShoppingListForUserByID(int id, int userId)
        {
            var shopppingList = _dbRepository.GetShoppingListByID(id);
            if (shopppingList == null)
            {
                throw new Exception("Shopping list not found");
            }
            if (shopppingList.UserId != userId)
            {
                throw new Exception("User is trying to access foreign shopping list");
            }
            return shopppingList;
        }

        public List<ShoppingList> GetUserShoppingLists(int userId)
        {
            return _dbRepository.GetShoppingListByUserId(userId);
        }

        public void UpdateShoppingListForUser(ShoppingList shoppingList, int userId)
        {
            var shopppingListfromDb = _dbRepository.GetShoppingListByID(shoppingList.Id);
            if (shopppingListfromDb == null)
            {
                throw new Exception("Shopping list not found");
            }
            if (shopppingListfromDb.UserId != userId)
            {
                throw new Exception("User is trying to update foreign shopping list");
            }
            _dbRepository.UpdateShoppingList(shoppingList);
        }
    }
}
