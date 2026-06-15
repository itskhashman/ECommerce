namespace ECommerce.Application.DTOs.Category
{
    public class CategoryDto : BaseDto
    {
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public int? ParentCategoryId { get; set; }
        public List<CategoryDto> Children { get; set; } = new List<CategoryDto>();
        public bool IsActive { get; set; }
    }
}
 