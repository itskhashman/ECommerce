

using ECommerce.Application.DTOs.Cart;

namespace ECommerce.Application.Interfaces
{
    public interface ICartService
    {
        public Task<CartDto> CreateCartAsync(int userId);
        public Task<CartDto> AddItemToCartAsync(int userId, int cartId, int skuId, int quantity);
        public Task<CartDto?> GetCartByUserIdAsync(int userId);
        public Task<CartDto> RemoveItemFromCartAsync(int cartId, int skuId);
        public Task<CartDto> UpdateCartItemQuantityAsync(int cartId, int skuId, int quantity);
        public Task ClearCartAsync(int cartId);
    }
}