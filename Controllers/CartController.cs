using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROJECT_BOOK_STORE_GROUP5_PRN222.Models;
using PROJECT_BOOK_STORE_GROUP5_PRN222.Services;
using PROJECT_BOOK_STORE_GROUP5_PRN222.ViewModels;

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetCart(String userId)
        {
            var cart = await _cartService.GetCartByUserId(userId);
            if (cart == null)
                return NotFound(new { message = "Cart not found for this user." });

            return Ok(cart);
        }

        [HttpPost("items")]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequest request)
        {
            var cart = await _cartService.AddCartAsync(request.UserId, request.BookId, request.Quantity);
            return Ok(new { message = "Book added to cart successfully!", cart });
        }

        [HttpPut("items/{itemId}")]
        public async Task<IActionResult> UpdateQuantity(long itemId, [FromBody] UpdateQuantityRequest request)
        {
            var updatedItem = await _cartService.UpdateCartItemQuantityAsync(itemId, request.Quantity);
            return Ok(new { message = "Quantity updated successfully!", updatedItem });
        }

        [HttpDelete("items/{itemId}")]
        public async Task<IActionResult> DeleteCartItem(long itemId)
        {
            await _cartService.DeleteCartItemAsync(itemId);
            return Ok(new { message = "Cart item deleted successfully!", itemId });
        }

        [HttpDelete("clear/{userId}")]
        public async Task<IActionResult> ClearCart(long userId)
        {
            await _cartService.ClearCartAsync(userId);
            return Ok(new { message = "Cart cleared successfully!" });
        }
    }
}
