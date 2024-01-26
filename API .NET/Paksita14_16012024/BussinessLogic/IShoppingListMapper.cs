using Paksita14_16012024.DTOs;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.BussinessLogic
{
    public interface IShoppingListMapper
    {
        ShoppingList Map(CreateShoppingListDto dto, int userId);
        ShoppingList Map(UpdateShoppingListDto dto, int userId);
        GetShoppingListDTO Map(ShoppingList model, int userId);
        List<GetShoppingListDTO> Map(IEnumerable<ShoppingList> model, int userId);
    }
}
