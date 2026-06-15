
using AutoMapper;
using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.DTOs.Order;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities.Sales;


namespace ECommerce.Application.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, ICartRepository cartRepository, IProductRepository productRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<int?> GetTotalOrdersAsync()
        {
            return await _orderRepository.GetTotalOrdersAsync();
        }

        public async Task<int?> GetTotalPendingAsync()
        {
            return await _orderRepository.GetTotalPendingAsync();
        }
        public async Task<int?> GetTotalConfirmedAsync()
        {
            return await _orderRepository.GetTotalConfirmedAsync();
        }
        public async Task<int?> GetTotalShippedAsync()
        {
            return await _orderRepository.GetTotalShippedAsync();
        }
        public async Task<int?> GetTotalDeliveredAsync()
        {
            return await _orderRepository.GetTotalDeliveredAsync();
        }
        public async Task<int?> GetTotalCancelledAsync()
        {
            return await _orderRepository.GetTotalCancelledAsync();
        }
        public async Task<decimal?> GetTotalSalesAsync()
        {
            return await _orderRepository.GetTotalSalesAsync();
        }   
        public async Task<Dictionary<DateTime, int>> GetLastWeekOrdersAsync()
        {
            return await _orderRepository.GetLastWeekOrdersAsync();
        }

        public async Task<IEnumerable<OrderDto>?> GetRecentOrdersAsync()
        {
            var recentOrders = await _orderRepository.GetRecentOrdersAsync();
            return _mapper.Map<IEnumerable<OrderDto>>(recentOrders);
        }
        public async Task<IEnumerable<OrderDto>?> GetAllOrdersAsync()
        {
            var orders = await _orderRepository.GetAllOrdersAsync();
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public async Task<IEnumerable<OrderDto>?> GetOrdersByUserIdAsync(int userId)
        {
            var orders = await _orderRepository.GetOrdersByUserIdAsync(userId);
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }
        public async Task<OrderDto?> GetOrderWithDetailsAsync(int orderId)
        {
            var order = await _orderRepository.GetOrderWithDetailsAsync(orderId);
            return _mapper.Map<OrderDto>(order);
        }
        public async Task<OrderDto?> CreateOrderByUserIdAsync(int userId, CartDto cart, int addressId, int paymentMethodId)
        {
            if (cart == null || cart.CartItems == null || !cart.CartItems.Any())
            {
                throw new ArgumentException("Cannot create an order from an empty cart.");
            }

            var orderItems = cart.CartItems.Select((item, index) =>
            {
                var basePrice = item.Sku.Price;
                var quantity = item.Quantity;
                decimal discountAmount = 0;

                if (item.Sku?.Product.DiscountTypeId != null)
                {
                    var product = item.Sku.Product;
                    if (product.DiscountTypeId == 1)
                    {
                        discountAmount = (basePrice * (product.DiscountAmount.Value / 100m)) * quantity;
                    }
                    else
                    {
                        discountAmount = product.DiscountAmount.Value * quantity;
                    }
                }

                var subTotal = (basePrice * quantity) - discountAmount;

                return new OrderItem
                {
                    SkuId = item.SkuId,
                    Quantity = quantity,
                    PriceAtPurchase = basePrice,
                    DiscountAmount = discountAmount,
                    SubTotal = subTotal,
                    OrderItemNumber = index + 1,
                    ProductNameEn = item.Sku?.Product?.NameEn,
                    ProductNameAr = item.Sku?.Product?.NameAr,
                    SkuCode = item.Sku?.SkuCode
                };
            }).ToList();

            var order = new Order
            {
                UserId = userId,
                OrderNumber = "",
                OrderItems = orderItems,
                TotalAmount = orderItems.Sum(x => x.SubTotal),
                CurrencyCode = "JOD",
                OrderStatusId = 1,
                AddressId = addressId,
                PaymentId = paymentMethodId,
                ShippingCost = 0
            };

            var createdOrder = await _orderRepository.CreateOrderByUserIdAsync(userId, order);

            createdOrder.OrderNumber = $"ORD-{createdOrder.Id.ToString("D8")}";
            createdOrder = await _orderRepository.UpdateOrderAsync(createdOrder);
            await _cartRepository.ClearCartAsync(cart.Id);
            foreach (var item in order.OrderItems)
            {
                await _productRepository.UpdateProductStockAsync(item.SkuId, item.Quantity);
            }
            return _mapper.Map<OrderDto>(createdOrder);
        }
        public async Task<OrderDto?> UpdateOrderAsync(int orderId, int orderStatusId)
        {
            var updatedOrder = await _orderRepository.UpdateOrderStateAsync(orderId, orderStatusId);
            return _mapper.Map<OrderDto>(updatedOrder);
        }
        public async Task DeleteOrderAsync(int orderId)
        {
            await _orderRepository.DeleteOrderAsync(orderId);
        }
    }
}