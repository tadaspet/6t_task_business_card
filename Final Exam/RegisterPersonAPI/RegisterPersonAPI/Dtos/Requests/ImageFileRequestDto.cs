using RegisterPersonAPI.CustomValidation;

namespace RegisterPersonAPI.DTOs.Requests
{
    public class ImageFileRequestDTO
    {
        [MaxFileSize(5 * 1024 * 1024)]  //5MB
        [AllowedExtensions(new[] { ".jpg", ".png" })]
        public IFormFile Image { get; set; }
    }
}
