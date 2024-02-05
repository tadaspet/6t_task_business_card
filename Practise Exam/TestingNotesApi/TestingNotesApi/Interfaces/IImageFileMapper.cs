using KeepNotesDAL.Entities;
using TestingNotesApi.Api.DTOs;
using TestingNotesApi.DTOs;

namespace TestingNotesApi.Interfaces
{
    public interface IImageFileMapper
    {
        List<ImageFilePushDTO> Map(IEnumerable<ImageFile> entities);
        ImageFilePushDTO Map(ImageFile entity);
        ImageFile Map(int noteId, ImageUploadRequest request);
    }
}