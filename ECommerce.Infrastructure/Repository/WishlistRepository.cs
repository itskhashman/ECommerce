

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Users;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class WishlistRepository : GenericRepository<Wishlist>, IWishlistRepository
    {
        public WishlistRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task AddToWishlistAsync(int wishlistId, int skuId)
        {
            _context.WishlistItems.Add(new WishlistItem { WishlistId = wishlistId, SkuId = skuId });
            await _context.SaveChangesAsync();
        }
        public async Task ClearWishlistAsync(int userId)
        {
            await _context.WishlistItems
                .Where(wi => wi.Wishlist.UserId == userId && !wi.IsDeleted)
                .ExecuteUpdateAsync(s => s.SetProperty(b => b.IsDeleted, true));
            await _context.SaveChangesAsync();

        }
        public async Task<Wishlist?> GetWishlistByUserIdAsync(int userId)
        {
            return await _context.Wishlists
                .Include(w => w.WishlistItems)
                .FirstOrDefaultAsync(w => w.UserId == userId);
        }   
        public async Task RemoveFromWishlistAsync(int userId, int skuId)
        { 
            var wishlistItem = await _context.WishlistItems
                .FirstOrDefaultAsync(wi => wi.Wishlist.UserId == userId && wi.SkuId == skuId && !wi.IsDeleted);

            if (wishlistItem != null)
            {
                wishlistItem.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
