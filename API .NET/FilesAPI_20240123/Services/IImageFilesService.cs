using FilesAPI_20240123.Models;

namespace FilesAPI_20240123.Services
{
    public interface IImageFilesService
    {
        ImageFile GetImageFile(int id);
        int AddImageFile(ImageFile imageFile);
    }
}
