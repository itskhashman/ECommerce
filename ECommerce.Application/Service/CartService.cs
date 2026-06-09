
using AutoMapper;
using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities.Users;


namespace ECommerce.Application.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CartService(ICartRepository cartRepository, IProductRepository productRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<CartDto> CreateCartAsync(int userId)
        {
            var cart = new Cart { UserId = userId };
            cart = await _cartRepository.AddAsync(cart);
            return _mapper.Map<CartDto>(cart);
        }
        public async Task<CartDto> AddItemToCartAsync(int userId, int cartId, int skuId, int quantity)
        {
            var sku = await _productRepository.GetProductBySkuId(skuId);
            var cart = await _cartRepository.GetCartByIdWithItemsAsync(userId);
            if (sku != null && cart.CartItems.Count > 0)
            {
                var cartQuantity = cart.CartItems.Where(c => c.SkuId == skuId).FirstOrDefault().Quantity;
                if (cartQuantity != null)
                    if (quantity + cartQuantity > sku.Skus.FirstOrDefault()?.Stock)
                    {
                        throw new InvalidOperationException("Not enough stock available.");
                    }
            }
            cart = await _cartRepository.AddItemToCartAsync(cartId, skuId, quantity);
            return _mapper.Map<CartDto>(cart);
        }
        public async Task<CartDto?> GetCartByUserIdAsync(int userId)
        {
            var cart = await _cartRepository.GetCartByIdWithItemsAsync(userId);
            if (cart == null)
            {
                return null;
            }
            return _mapper.Map<CartDto>(cart);
        }
        public async Task<CartDto> RemoveItemFromCartAsync(int cartId, int skuId)
        {
            var cart = await _cartRepository.RemoveItemFromCartAsync(cartId, skuId);
            return _mapper.Map<CartDto>(cart);
        }
        public async Task<CartDto> UpdateCartItemQuantityAsync(int cartId, int skuId, int quantity)
        {
            var cart = await _cartRepository.UpdateCartItemQuantityAsync(cartId, skuId, quantity);
            return _mapper.Map<CartDto>(cart);
        }
        public async Task ClearCartAsync(int cartId)
        {
            await _cartRepository.ClearCartAsync(cartId);
        }
    }
}