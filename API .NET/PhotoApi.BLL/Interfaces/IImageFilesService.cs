using FilesAPI_20240123.Models;

namespace PhotoApi.BLL.Interfaces
{
    public interface IImageFilesService
    {
        ImageFile GetImageFile(int id);
        int AddImageFile(ImageFile imageFile);
    }
}
