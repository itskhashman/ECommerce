

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
        public async Task AddToWishlistAsync(int wishlistId, int productId)
        {
            var existingItem = await _context.WishlistItems
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync(w => w.WishlistId == wishlistId && w.ProductId == productId);

            if (existingItem != null)
            {
                if (existingItem.IsDeleted)
                {
                    existingItem.IsDeleted = false;
                }
            }
            else
            {
                var newItem = new WishlistItem
                {
                    WishlistId = wishlistId,
                    ProductId = productId,
                };
                _context.WishlistItems.Add(newItem);
            }

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
                .AsNoTracking()
                .Include(w => w.WishlistItems.Where(wi => !wi.IsDeleted))
                    .ThenInclude(wi => wi.Product)
                        .ThenInclude(p => p.Skus)
                .Include(w => w.WishlistItems.Where(wi => !wi.IsDeleted))
                    .ThenInclude(wi => wi.Product)
                        .ThenInclude(p => p.ProductImages.Where(img => !img.IsDeleted && img.IsMain))
                .FirstOrDefaultAsync(w => w.UserId == userId && !w.IsDeleted);
        }
        public async Task RemoveFromWishlistAsync(int userId, int productId)
        {
            var wishlistItem = await _context.WishlistItems
                .FirstOrDefaultAsync(wi => wi.Wishlist.UserId == userId && wi.ProductId == productId && !wi.IsDeleted);

            if (wishlistItem != null)
            {
                wishlistItem.IsDeleted = true;
                wishlistItem.DeletedAt = DateTime.UtcNow;
                wishlistItem.DeletedBy = userId;
                await _context.SaveChangesAsync();
            }
        }
    }
}
