using ECommerce.Application.DTOs.Address;
using ECommerce.Application.DTOs.Cart;

namespace ECommerce.Web.Models.ViewModels.Checkout
{
    public class CheckoutViewModel
    {
        public CartDto Cart { get; set; } = null!;
        public int AddressId { get; set; }
        public int PaymentId { get; set; }

        public IEnumerable<AddressDto> UserAddresses { get; set; } = new List<AddressDto>();
    }
}