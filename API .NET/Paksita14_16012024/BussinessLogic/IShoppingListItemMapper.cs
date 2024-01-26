using Paksita14_16012024.DTOs;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.BussinessLogic
{
    public interface IShoppingListItemMapper
    {
        public List<ShopppingListItemDto> Map(IEnumerable<ShoppingListItem> model);
        public ShopppingListItemDto Map(ShoppingListItem model);
        public List<ShoppingListItem> Map(IEnumerable<ShopppingListItemDto> dto);
        public ShoppingListItem Map(ShopppingListItemDto dto, int index);

    }
}
