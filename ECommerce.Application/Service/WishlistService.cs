using AutoMapper;
using ECommerce.Application.DTOs.Wishlist;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities.Users;


namespace ECommerce.Application.Service
{
    public class WishlistService : IWishlistService
    {
        private readonly IWishlistRepository _wishlistRepository;
        private readonly IMapper _mapper;
        public WishlistService(IWishlistRepository wishlistRepository, IMapper mapper)
        {
            _wishlistRepository = wishlistRepository;
            _mapper = mapper;
        }

        public async Task AddItemToWishlistAsync(int wishlistId, WishlistItemDto wishlistItemDto)
        {
            await _wishlistRepository.AddToWishlistAsync(wishlistId, wishlistItemDto.ProductId);
        }
        public async Task<WishlistDto> GetWishlistByUserIdAsync(int userId)
        {
            var wishlist = await _wishlistRepository.GetWishlistByUserIdAsync(userId);
            return _mapper.Map<WishlistDto>(wishlist);
        }
        public async Task RemoveItemFromWishlistAsync(int userId, int productId)
        {
            await _wishlistRepository.RemoveFromWishlistAsync(userId, productId);
        }
        public async Task ClearWishlistAsync(int wishlistId)
        {
            await _wishlistRepository.ClearWishlistAsync(wishlistId);
        }
        public async Task<WishlistDto> CreateWishlistAsync(int userId)
        {
            var wishlist = await _wishlistRepository.AddAsync(new Wishlist { UserId = userId });
            return _mapper.Map<WishlistDto>(wishlist);
        }
    }
}