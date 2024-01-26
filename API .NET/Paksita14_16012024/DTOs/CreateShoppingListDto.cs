using Paksita14_16012024.Models;

namespace Paksita14_16012024.DTOs
{
    public class CreateShoppingListDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public List<ShopppingListItemDto> Items { get; set; }
    }
}
