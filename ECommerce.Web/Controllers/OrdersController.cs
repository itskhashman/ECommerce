using ECommerce.Application.Interfaces;
using ECommerce.Web.Models.ViewModels.Checkout;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        private readonly IUserService _userService;

        public OrdersController(IOrderService orderService, ICartService cartService, IUserService userService)
        {
            _orderService = orderService;
            _cartService = cartService;
            _userService = userService;
        }
        [HttpGet("Orders")]
        public async Task<IActionResult> Index()
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;

            var orders = await _orderService.GetOrdersByUserIdAsync(userId);

            return View(orders);
        }

        [HttpGet("Orders/Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var order = await _orderService.GetOrderWithDetailsAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        [HttpGet("Checkout/PlaceOrder")]
        public async Task<IActionResult> PlaceOrder()
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;

            var cart = await _cartService.GetCartByUserIdAsync(userId);
            if (cart == null || !cart.CartItems.Any())
            {
                return RedirectToAction("Cart", "Cart");
            }

            var addresses = await _userService.GetUserAddressesAsync(userId);

            var viewModel = new CheckoutViewModel
            {
                Cart = cart,
                UserAddresses = addresses,
                AddressId = addresses.FirstOrDefault()?.Id ?? 0, 
                PaymentId = 1 
            };

            return View(viewModel);
        }

        [HttpPost("Checkout/PlaceOrderSubmit")]
        public async Task<IActionResult> PlaceOrderSubmit(CheckoutViewModel model)
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;

            var cart = await _cartService.GetCartByUserIdAsync(userId);
            if (cart == null || !cart.CartItems.Any())
            {
                return RedirectToAction("Cart", "Cart");
            }

            var createdOrder = await _orderService.CreateOrderByUserIdAsync(
                userId,
                cart,
                model.AddressId,
                model.PaymentId
            );

            return RedirectToAction("Success", new { orderId = createdOrder.Id });
        }

        [HttpGet("Checkout/Success/{orderId}")]
        public async Task<IActionResult> Success(int orderId)
        {
            var order = await _orderService.GetOrderWithDetailsAsync(orderId);
            if (order == null) return NotFound();

            return View(order);
        }
        [HttpGet("Manage/Orders")]
        public async Task<IActionResult> Manage()
        {
            var order = await _orderService.GetAllOrdersAsync();
            if (order == null) return NotFound();

            return View(order);
        }
    }
}