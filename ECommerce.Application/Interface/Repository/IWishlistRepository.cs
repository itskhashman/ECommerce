

using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.Interface.Repository
{
    public interface IWishlistRepository : IGenericRepository<Wishlist>
    {
        public Task<Wishlist?> GetWishlistByUserIdAsync(int userId);
        public Task AddToWishlistAsync(int wishlistId, int productId);
        public Task RemoveFromWishlistAsync(int wishlistId, int productId);
        public Task ClearWishlistAsync(int wishlistId);
    }
}
