using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface IImageFileMapper
    {
        ImageFile Map(ImageFileRequestDTO dto, int personInfoId);
    }
}