

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
        public async Task<Dictionary<DateTime, int>> GetLastWeekOrdersAsync()
        {
            var last7DaysStart = DateTime.UtcNow.Date.AddDays(-6);

            var ordersPerDay = await _context.Orders
                .Where(o => !o.IsDeleted && o.CreatedAt >= last7DaysStart)
                .GroupBy(o => o.CreatedAt.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Count = g.Count()
                })
                .OrderBy(g => g.Date)
                .ToListAsync();

            return ordersPerDay.ToDictionary(x => x.Date, x => x.Count);
        }
        public async Task<int?> GetTotalOrdersAsync()
        {
            return await _context.Orders.Where(o => !o.IsDeleted).CountAsync();
        }
        public async Task<int?> GetTotalPendingAsync()
        {
            return await _context.Orders.Where(o => !o.IsDeleted && o.OrderStatusId == 1).CountAsync();
        }
        public async Task<int?> GetTotalConfirmedAsync()
        {
            return await _context.Orders.Where(o => !o.IsDeleted && o.OrderStatusId == 2).CountAsync();
        }
        public async Task<int?> GetTotalShippedAsync()
        {
            return await _context.Orders.Where(o => !o.IsDeleted && o.OrderStatusId == 3).CountAsync();
        }
        public async Task<int?> GetTotalDeliveredAsync()
        {
            return await _context.Orders.Where(o => !o.IsDeleted && o.OrderStatusId == 4).CountAsync();
        }
        public async Task<int?> GetTotalCancelledAsync()
        {
            return await _context.Orders.Where(o => o.IsDeleted).CountAsync();
        }
        public async Task<decimal?> GetTotalSalesAsync()
        {
            return await _context.Orders.Where(o => !o.IsDeleted).SumAsync(o => o.TotalAmount);
        }
        public async Task<IEnumerable<Order>?> GetRecentOrdersAsync()
        {
            return await _context.Orders
                .Where(o => !o.IsDeleted)
                .OrderByDescending(o => o.CreatedAt)
                .Take(10)
                .ToListAsync();
        }
        public async Task<IEnumerable<Order>?> GetAllOrdersAsync()
        {
            var orders = await _context.Orders.
                Where(o => !o.IsDeleted)
                .Include(o => o.User)
                .ToListAsync();
            return orders;

        }
        public async Task<IEnumerable<Order>?> GetOrdersByUserIdAsync(int userId)
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
        public async Task<Order?> GetOrderWithDetailsAsync(int orderId)
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
        public async Task<Order?> CreateOrderByUserIdAsync(int userId, Order order)
        {
            order.UserId = userId;
            var result = _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Order?> UpdateOrderAsync(Order order)
        {
            var result = _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Order?> DeleteOrderAsync(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                return null;
            }
            order.IsDeleted = true;
            var result = _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Order?> UpdateOrderStateAsync(int orderId, int orderStatusId)
        {
            var order = _context.Orders.Where(o => o.Id == orderId).FirstOrDefault();
            if (order == null)
            {
                return null;
            }
            else
            {
                order.OrderStatusId = orderStatusId;
            }
            await _context.SaveChangesAsync();
            return order;
        }
    }
}