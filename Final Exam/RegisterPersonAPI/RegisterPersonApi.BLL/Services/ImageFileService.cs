using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonApi.DAL.Repositories.Interfaces;
using System.Drawing;

namespace RegisterPersonApi.BLL.Services
{
    public class ImageFileService : IImageFileService
    {
        private readonly IImageFileRepository _repository;

        public ImageFileService(IImageFileRepository repository)
        {
            _repository = repository;
        }

        public byte[] ResizeImage(MemoryStream memoryStream)
        {
            var dtoImageBytes = memoryStream.ToArray();
            using var copyDtoImageInStream = new MemoryStream(dtoImageBytes);
            using var originalImage = new Bitmap(copyDtoImageInStream);

            using var resizedImage = new Bitmap(200, 200);

            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(originalImage, 0, 0, 200, 200);
            }

            using var resultStream = new MemoryStream();
            resizedImage.Save(resultStream, originalImage.RawFormat);
            return resultStream.ToArray();
        }

        public ImageFile GetImageFile(Guid userId)
        {
            return _repository.GetImageFile(userId);
        }

        public int AddImageFile(ImageFile imageFile, Guid userId)
        {
            var dbimageFile = _repository.GetImageFile(userId);
            if (dbimageFile != null)
            {
                _repository.DeleteImageFile(dbimageFile.Id);
            }
            return _repository.AddImageFile(imageFile);
        }

        public bool DeleteImageFile(Guid userId)
        {
            var image = _repository.GetImageFile(userId);
            if (image == null)
            {
                return false;
            }
            var isDeleted = _repository.DeleteImageFile(image.Id);
            if (!isDeleted)
            {
                return false;
            }
            return true;
        }
    }
}
