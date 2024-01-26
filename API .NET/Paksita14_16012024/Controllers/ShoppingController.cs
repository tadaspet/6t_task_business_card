using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paksita14_16012024.BussinessLogic;
using Paksita14_16012024.DTOs;
using Paksita14_16012024.Models;

namespace Paksita14_16012024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;
        private readonly IShoppingListMapper _mapper;
        private readonly IUserManagerService _userManagerService;

        public ShoppingController(IShoppingListService shoppingListService, IShoppingListMapper shoppingListMapper, IUserManagerService userManagerService)
        {
            _shoppingListService = shoppingListService;
            _mapper = shoppingListMapper;
            _userManagerService = userManagerService;
        }

        [HttpGet]
        public IActionResult GetAllShoppingLists()
        {
            var userId = _userManagerService.GetCurrentUserId();
            List<ShoppingList> shoppingLists = _shoppingListService.GetUserShoppingLists(userId);
            var dto = _mapper.Map(shoppingLists, userId);
            return Ok(dto);
        }

        [HttpGet("{id}")]        
        public IActionResult GetShoppingListById(int id, int userId)
        {
            var shopppingList = _shoppingListService.GetShoppingListForUserByID(id, userId);
            var dto = _mapper.Map(shopppingList, userId);
            return Ok(dto);
        }

        [HttpPost]
        public IActionResult CreateShoppingList(CreateShoppingListDto shopppingListDto, int userId)
        {
            var shoppingListEntity = _mapper.Map(shopppingListDto, userId);
            var shoppingListId = _shoppingListService.CreateShoppingList(shoppingListEntity);
            return Created(nameof(GetShoppingListById), new {id = shoppingListId});
        }

        [HttpPut]
        public IActionResult UpdateShoppingList(UpdateShoppingListDto dto, int userId) 
        {
            var entity = _mapper.Map(dto, userId);
            _shoppingListService.UpdateShoppingListForUser(entity, userId);
            return NoContent(); 
        }

        [HttpDelete]
        public IActionResult DeleteShoppingList(int id, int userId)
        {
            _shoppingListService.DeleteShoppingListForUser(id, userId);
            return Ok();
        }
    }
}
