using KeepNotesDAL.Entities;

namespace TestingNotesDAL.Interfacees
{
    public interface IImageRepository
    {
        int AddImageFile(ImageFile imageFile);
        void DeleteImageFile(int id);
        ImageFile GetImageFile(int id);
        ImageFile GetByImageIdAndUser(int imageId, int userId);
    }
}