using ECommerce.Application.DTOs.User;
using ECommerce.Application.DTOs.Lookups;

namespace ECommerce.Domain.Entities.Users
{
    public class UsersRolesDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;
        public int RoleId { get; set; }
        public RoleDto Role { get; set; } = null!;
      
    }

}
