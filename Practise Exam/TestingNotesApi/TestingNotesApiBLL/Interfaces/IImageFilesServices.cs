using KeepNotesDAL.Entities;

namespace TestingNotesApiBLL.Interfaces
{
    public interface IImageFilesServices
    {
        int AddImageFile(ImageFile imageFile);
        ImageFile GetByImageIdAndUser(int imageId, int userId);
        ImageFile GetImageFile(int id);
    }
}