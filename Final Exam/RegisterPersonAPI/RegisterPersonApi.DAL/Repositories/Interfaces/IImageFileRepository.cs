using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.Repositories.Interfaces
{
    public interface IImageFileRepository
    {
        int AddImageFile(ImageFile imageFile);
        bool DeleteImageFile(int id);
        ImageFile GetImageFile(Guid userId);
    }
}