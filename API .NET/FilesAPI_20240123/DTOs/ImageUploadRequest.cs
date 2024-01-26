using FilesAPI_20240123.Attributes;

namespace FilesAPI_20240123.DTOs
{
    public class ImageUploadRequest
    {
        [MaxFileSize(5 * 1024 * 1024)]  //5MB
        [AllowedExtensions(new[] {".jpg", ".png"})]
        public IFormFile Image { get; set; }
    }
}
