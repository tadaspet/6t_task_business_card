using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Dtos.Results;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface IPersonInfoMapper
    {
        PersonInformation Map(PersonInfoRequestDto dto, Guid userId);
        PersonInfoResultDto Map(PersonInformation entity);
    }
}