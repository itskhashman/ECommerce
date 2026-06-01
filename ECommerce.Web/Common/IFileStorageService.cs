namespace ECommerce.Web.Common
{
    public interface IFileStorageService
    {
        Task<string> UploadFileAsync(IFormFile file, string subFolder, string customFileNameWithoutExtension);
    }
}