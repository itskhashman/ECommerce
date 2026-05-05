

using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.Interface.Repository
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        public Task<IEnumerable<Cart>> GetCartWithItemsAsync(int userId);
        public Task RemoveItemFromCartAsync(int cartId, int skuId);
        public Task UpdateCartItemQuantityAsync(int cartId, int skuId, int quantity);
        public Task ClearCartAsync(int cartId);
    }
}
