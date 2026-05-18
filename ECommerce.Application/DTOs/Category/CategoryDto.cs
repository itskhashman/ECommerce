namespace ECommerce.Application.DTOs.Category
{
    public class CategoryDto : BaseDto
    {
        public string NameAr { get; set; } = null!;

        public string NameEn { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public int? ParentCategoryId { get; set; }

        public bool IsActive { get; set; }
    }
}
