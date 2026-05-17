

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Users;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Cart>> GetCartWithItemsAsync(int userId)
        {
            return await _context.Carts
                .AsNoTracking()
                .Where(c => c.UserId == userId)
                .Include(o => o.CartItems.Where(ci => ci.IsDeleted == false))
                .ThenInclude(oi => oi.Sku)
                        .ThenInclude(s => s.Product)
                            .ThenInclude(p => p.ProductImages)
                .ToListAsync();
        }
        public async Task RemoveItemFromCartAsync(int cartId, int skuId)
        {
            await _context.CartItems.Where(ci => ci.CartId == cartId && ci.SkuId == skuId).ExecuteUpdateAsync(ci => ci.SetProperty(c => c.IsDeleted, true));
        }
        public async Task UpdateCartItemQuantityAsync(int cartId, int skuId, int quantity)
        {
            await _context.CartItems.Where(ci => ci.CartId == cartId && ci.SkuId == skuId).ExecuteUpdateAsync(ci => ci.SetProperty(c => c.Quantity, quantity));
        }
        public async Task ClearCartAsync(int cartId)
        {
            await _context.CartItems.Where(ci => ci.CartId == cartId).ExecuteUpdateAsync(ci => ci.SetProperty(c => c.IsDeleted, true));
        }
    }
}