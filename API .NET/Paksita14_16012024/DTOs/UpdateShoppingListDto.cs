namespace Paksita14_16012024.DTOs
{
    public class UpdateShoppingListDto
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public List<ShopppingListItemDto> Items { get; set; }
    }
}
