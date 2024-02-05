using KeepNotesDAL.Entities;
using TestingNotesApi.Api.DTOs;
using TestingNotesApi.DTOs;
using TestingNotesApi.Interfaces;

namespace TestingNotesApi.Mappers
{
    public class ImageFileMapper : IImageFileMapper
    {
        public ImageFilePushDTO Map(ImageFile entity)
        {
            return new ImageFilePushDTO
            {
                Id = entity.Id,
                FileName = entity.FileName,
                ContentType = entity.ContentType,
                Size = entity.Size,
            };
        }
        public List<ImageFilePushDTO> Map(IEnumerable<ImageFile> entities)
        {
            return entities.Select(Map).ToList();
        }

        public ImageFile Map(int noteId, ImageUploadRequest request)
        {
            using var memoryStream = new MemoryStream();
            request.Image.CopyTo(memoryStream);
            var imageBytes = memoryStream.ToArray();

            return new ImageFile
            {
                NoteId = noteId,
                Content = imageBytes,
                ContentType = request.Image.ContentType,
                FileName = request.Image.FileName,
                Size = imageBytes.Length,
            };
        }
    }
}
