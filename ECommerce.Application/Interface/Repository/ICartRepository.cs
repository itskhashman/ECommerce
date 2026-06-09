

using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.Interface.Repository
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        public Task<Cart> GetCartByIdWithItemsAsync(int userId);
        public Task<Cart> AddItemToCartAsync(int cartId, int skuId, int quantity);
        public Task<Cart> RemoveItemFromCartAsync(int cartId, int skuId);
        public Task<Cart> UpdateCartItemQuantityAsync(int cartId, int skuId, int quantity);
        public Task ClearCartAsync(int cartId);
    }
}
