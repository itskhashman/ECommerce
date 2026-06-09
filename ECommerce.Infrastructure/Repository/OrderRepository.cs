

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
        {
            return await _context.Orders
                .AsNoTracking()
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Sku)
                        .ThenInclude(s => s.Product)
                            .ThenInclude(p => p.ProductImages)
                .Include(o => o.OrderStatus)
                .ToListAsync();
        }
        public async Task<Order> GetOrderWithDetailsAsync(int orderId)
        {
            return await _context.Orders
                .AsNoTracking()
                .Where(o => o.Id == orderId)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Sku)
                        .ThenInclude(s => s.Product)
                            .ThenInclude(p => p.ProductImages)
                .Include(o => o.OrderStatus)
                .FirstOrDefaultAsync();
        }
        public async Task<Order> CreateOrderByUserIdAsync(int userId, Order order)
        {
            order.UserId = userId;
            var result = _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Order> UpdateOrderAsync(Order order)
        {
            var result = _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}