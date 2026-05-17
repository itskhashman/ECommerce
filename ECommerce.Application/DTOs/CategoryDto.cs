

namespace ECommerce.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }

        public string NameAr { get; set; } = null!;

        public string NameEn { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public int? ParentCategoryId { get; set; }

        public bool IsActive { get; set; }
    }
}
