

using ECommerce.Application.DTOs.Wishlist;

namespace ECommerce.Application.Interfaces
{
    public interface IWishlistService
    {
        Task<WishlistDto?> CreateWishlistAsync(int userId);
        Task AddItemToWishlistAsync(int wishlistId, WishlistItemDto wishlistItemDto);
        Task<WishlistDto?> GetWishlistByUserIdAsync(int userId);
        Task RemoveItemFromWishlistAsync(int userId, int productId);
        Task ClearWishlistAsync(int wishlistId);
    }
}