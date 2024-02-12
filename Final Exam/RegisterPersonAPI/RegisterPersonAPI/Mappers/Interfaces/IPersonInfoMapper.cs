using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;
using RegisterPersonAPI.DTOs.Results;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface IPersonInfoMapper
    {
        PersonInformation Map(PersonInfoRequestDTO dto, Guid userId);
        PersonInfoResultDto Map(PersonInformation entity);
    }
}