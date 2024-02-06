using Azure.Core;
using RegisterPersonApi.BLL.Services.Interfaces;
using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Mappers.Interfaces;
using System.Drawing;

namespace RegisterPersonAPI.Mappers
{
    public class ImageFileMapper : IImageFileMapper
    {
        private readonly IImageFileService _imageFileService;

        public ImageFileMapper(IImageFileService imageFileService)
        {
            _imageFileService = imageFileService;
        }

        public ImageFile Map(ImageFileRequestDto dto, int personInfoId)
        {
            using var memoryStream = new MemoryStream();
            dto.Image.CopyTo(memoryStream);

            var updatedImage = _imageFileService.ResizeImage(memoryStream);

            var entity = new ImageFile
            {
                FileName = dto.Image.FileName,
                ContentType = dto.Image.ContentType,
                Size = updatedImage.Length,
                Content = updatedImage,
                CreationDate = DateTime.Now,
                PersonInformationId = personInfoId
            };
            return entity;

        }


    }
}
