using Paksita14_16012024.DTOs;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.BussinessLogic
{
    public class ShoppingListItemMapper : IShoppingListItemMapper
    {
        public ShoppingListItem Map(ShopppingListItemDto dto, int index)
        {
            var shoppingListEntity = new ShoppingListItem
            {
                Title = dto.Title,
                Quantity = dto.Quantity,
                Order = index
            };
            return shoppingListEntity;
        }
        public List<ShoppingListItem> Map(IEnumerable<ShopppingListItemDto> dto)
        {
            return dto.Select(Map).ToList();

            //return dto.Select((x, i) => new ShoppingListItem
            //{
            //    Title = x.Title,
            //    Quantity = x.Quantity,
            //    Order = i + 1,
            //}).ToList();            
        }

        public ShopppingListItemDto Map(ShoppingListItem model)
        {
            var shoppingListEntity = new ShopppingListItemDto
            {
                Title = model.Title,
                Quantity = model.Quantity,
            };
            return shoppingListEntity;
        }

        public List<ShopppingListItemDto> Map(IEnumerable<ShoppingListItem> model)
        {
            return model.Select(Map).ToList();            
        }



    }
}
