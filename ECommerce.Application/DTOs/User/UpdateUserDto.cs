


namespace ECommerce.Application.DTOs.User
{
    public class UpdateUserDto : BaseDto      
    {
        public string FirstNameEn { get; set; }
        public string MiddleNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string FirstNameAr { get; set; }
        public string MiddleNameAr { get; set; }
        public string LastNameAr { get; set; }
        public string Phone { get; set; }
    }
}
