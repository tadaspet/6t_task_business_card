using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Dtos.Results;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface ISettlementMapper
    {
        SettlementResultDto Map(Settlement entity);
        Settlement Map(SettlementRequestDto Dto, int personInfoId);
    }
}