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
        public async Task<Cart> GetCartByIdWithItemsAsync(int userId)
        {
            return await _context.Carts
                .AsNoTracking()
                .Where(c => c.UserId == userId)
                .Include(o => o.CartItems.Where(ci => ci.IsDeleted == false))
                .ThenInclude(oi => oi.Sku)
                        .ThenInclude(s => s.Product)
                            .ThenInclude(p => p.ProductImages)
                .FirstOrDefaultAsync();
        }
        public async Task<Cart> AddItemToCartAsync(int cartId, int skuId, int quantity)
        {
            var existingCartItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.CartId == cartId && ci.SkuId == skuId);
            if (existingCartItem != null)
            {
                if (existingCartItem.IsDeleted)
                    existingCartItem.Quantity = quantity;
                else
                    existingCartItem.Quantity += quantity;
                existingCartItem.IsDeleted = false;
                _context.CartItems.Update(existingCartItem);
            }
            else
            {
                var discount = await _context.Products.Where(p => p.Skus.Any(s => s.Id == skuId))
                    .Select(p => new { p.DiscountTypeId, p.DiscountAmount }).FirstOrDefaultAsync();

                var price = await _context.Products.Where(p => p.Skus.Any(s => s.Id == skuId))
                    .Select(p => p.Skus.FirstOrDefault(s => s.Id == skuId).Price).FirstOrDefaultAsync();

                if (discount != null && discount.DiscountAmount.HasValue)
                {
                    if (discount.DiscountTypeId == 1)
                    {
                        price = price * (1 - discount.DiscountAmount.Value / 100);
                    }
                    else if (discount.DiscountTypeId == 2)
                    {
                        price = price - discount.DiscountAmount.Value;
                    }
                }

                var newCartItem = new CartItem
                {
                    CartId = cartId,
                    SkuId = skuId,
                    Quantity = quantity,
                    IsDeleted = false,
                    PriceAtAddTime = price
                };
                await _context.CartItems.AddAsync(newCartItem);
            }
            await _context.SaveChangesAsync();
            return await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.Id == cartId);
        }
        public async Task<Cart> RemoveItemFromCartAsync(int cartId, int skuId)
        {
            await _context.CartItems.Where(ci => ci.CartId == cartId && ci.SkuId == skuId).ExecuteUpdateAsync(ci => ci.SetProperty(c => c.IsDeleted, true));
            return await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.Id == cartId);
        }
        public async Task<Cart> UpdateCartItemQuantityAsync(int cartId, int skuId, int quantity)
        {
            await _context.CartItems.Where(ci => ci.CartId == cartId && ci.SkuId == skuId).ExecuteUpdateAsync(ci => ci.SetProperty(c => c.Quantity, quantity));
            return await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.Id == cartId);
        }
        public async Task ClearCartAsync(int cartId)
        {
            await _context.CartItems.Where(ci => ci.CartId == cartId).ExecuteUpdateAsync(ci => ci.SetProperty(c => c.IsDeleted, true));
        }
    }
}