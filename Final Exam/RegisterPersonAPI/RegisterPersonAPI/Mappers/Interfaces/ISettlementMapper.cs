using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;
using RegisterPersonAPI.DTOs.Results;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface ISettlementMapper
    {
        SettlementResultDto Map(Settlement entity);
        Settlement Map(SettlementRequestDto Dto, int personInfoId);
    }
}