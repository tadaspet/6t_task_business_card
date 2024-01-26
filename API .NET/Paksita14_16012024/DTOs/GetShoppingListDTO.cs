using Paksita14_16012024.Models;

namespace Paksita14_16012024.DTOs
{
    public class GetShoppingListDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public List<ShopppingListItemDto> Items { get; set; }
    }
}
