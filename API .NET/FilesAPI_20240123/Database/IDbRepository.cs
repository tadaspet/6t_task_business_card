using FilesAPI_20240123.Models;

namespace FilesAPI_20240123.Database
{
    public interface IDbRepository
    {
        ImageFile GetImageFile(int id);
        int AddImageFile(ImageFile imageFile);
        void DeleteImageFile(int id);
    }
}
