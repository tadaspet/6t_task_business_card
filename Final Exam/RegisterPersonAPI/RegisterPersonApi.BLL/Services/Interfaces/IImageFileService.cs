using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.BLL.Services.Interfaces
{
    public interface IImageFileService
    {
        int AddImageFile(ImageFile imageFile, Guid userId);
        bool DeleteImageFile(Guid userId);
        ImageFile GetImageFile(Guid userId);
        byte[] ResizeImage(MemoryStream memoryStream);
    }
}