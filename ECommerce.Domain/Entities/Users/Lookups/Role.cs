

using ECommerce.Domain.Entities.Base;

namespace ECommerce.Domain.Entities.Users.Lookups
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; } = null!;
    }

}
