using RegisterPersonAPI.CustomValidation;

namespace RegisterPersonAPI.Dtos.Requests
{
    public class ImageFileRequestDto
    {
        [MaxFileSize(5 * 1024 * 1024)]  //5MB
        [AllowedExtensions(new[] { ".jpg", ".png" })]
        public IFormFile Image { get; set; }
    }
}
