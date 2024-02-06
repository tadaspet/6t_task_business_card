using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface IImageFileMapper
    {
        ImageFile Map(ImageFileRequestDto dto, int personInfoId);
    }
}