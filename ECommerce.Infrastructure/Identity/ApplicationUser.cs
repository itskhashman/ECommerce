using Microsoft.AspNetCore.Identity;

namespace ECommerce.Infrastructure.Identity;

public class ApplicationUser : IdentityUser<int>
{
    public int DomainUserId { get; set; }
}