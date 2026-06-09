
using ECommerce.Application.DTOs.Address;
using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.DTOs.Order;
using ECommerce.Application.DTOs.Wishlist;

namespace ECommerce.Application.DTOs.User
{
    public class UserDto : BaseDto      
    {
        public string FirstNameEn { get; set; }
        public string MiddleNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string FirstNameAr { get; set; }
        public string MiddleNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsEmailVerified { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public ICollection<OrderDto>? Orders { get; set; } = new List<OrderDto>();
        public ICollection<AddressDto>? Address { get; set; } = new List<AddressDto>();
        public CartDto? Cart { get; set; }
        public WishlistDto? Wishlist { get; set; }
    }
}
