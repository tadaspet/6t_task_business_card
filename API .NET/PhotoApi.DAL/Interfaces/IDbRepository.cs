using FilesAPI_20240123.Models;

namespace PhotoApi.DAL.Interfaces
{
    public interface IDbRepository
    {
        ImageFile GetImageFile(int id);
        int AddImageFile(ImageFile imageFile);
        void DeleteImageFile(int id);
    }
}
