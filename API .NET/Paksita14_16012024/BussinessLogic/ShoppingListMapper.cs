using Paksita14_16012024.DTOs;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.BussinessLogic
{
    public class ShoppingListMapper : IShoppingListMapper
    {
        private readonly IShoppingListItemMapper _mapper;

        public ShoppingListMapper(IShoppingListItemMapper mapper)
        {
            _mapper = mapper;
        }

        public ShoppingList Map(CreateShoppingListDto dto, int userId)
        {
            var shoppingListEntity = new ShoppingList
            {
                Title = dto.Title,
                UserId = userId,
                Description = dto.Description,
                Items = _mapper.Map(dto.Items)
            };
            return shoppingListEntity;

            //return new ShoppingList
            //{
            //    Title = dto.Title,
            //    UserId = userId,
            //    Description = dto.Description,
            //    Items = dto.Items.Select((x, i) => new ShoppingListItem
            //    {
            //        Title = x.Title,
            //        Quantity = x.Quantity,
            //        Order = i+1,
            //    }).ToList()
            //};
        }
        public ShoppingList Map(UpdateShoppingListDto dto, int userId)
        {
            var shoppingListEntity = new ShoppingList
            {
                Title = dto.Title,
                UserId = userId,
                Description = dto.Description,
                Items = _mapper.Map(dto.Items)
            };
            return shoppingListEntity;
        }
        public GetShoppingListDTO Map(ShoppingList model, int userId)
        {
            var entity = new GetShoppingListDTO
            {
                Id = model.Id,
                Title = model.Title,
                UserId = userId,
                Description = model.Description,
                Items = _mapper.Map(model.Items),
                //Items = model.Items.Select(x => new ShopppingListItemDto
                //{
                //    Title = x.Title,
                //    Quantity = x.Quantity,
                //}).ToList()
            };
            return entity;
        }

        public List<GetShoppingListDTO> Map(IEnumerable<ShoppingList> model, int userId)
        {
            //return model.Select(x => Map(x, userId)).ToList();
            //return model.Select(Map).ToList();
            //return model.Select((x, i) => Map(x, i)).ToList();
            return model.Select(x => Map(x, userId)).ToList();
        }
    }
}
