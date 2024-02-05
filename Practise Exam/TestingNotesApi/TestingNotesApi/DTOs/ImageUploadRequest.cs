using TestingNotesApi.CustomValidation;

namespace TestingNotesApi.Api.DTOs
{
    public class ImageUploadRequest
    {
        /// <summary>
        /// Validation of DTO IFormFile to be less than 5MB and jpg/png extensions
        /// </summary>
        [MaxFileSize(5 * 1024 * 1024)] 
        [AllowedExtensions(new[] { ".jpg", ".png" })]
        public IFormFile Image { get; set; }
    }
}
