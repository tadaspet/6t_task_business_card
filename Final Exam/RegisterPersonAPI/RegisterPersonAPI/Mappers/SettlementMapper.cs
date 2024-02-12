using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;
using RegisterPersonAPI.DTOs.Results;
using RegisterPersonAPI.Mappers.Interfaces;

namespace RegisterPersonAPI.Mappers
{
    public class SettlementMapper : ISettlementMapper
    {
        public Settlement Map(SettlementRequestDto Dto, int personInfoId)
        {
            var entity = new Settlement
            {
                City = Dto.City,
                Street = Dto.Street,
                BuildingNo = Dto.BuildingNo,
                FlatNo = Dto.FlatNo == null ? null : Dto.FlatNo.ToString(),
                PersonInformationId = personInfoId
            };
            return entity;
        }

        public SettlementResultDto Map(Settlement entity)
        {
            var dto = new SettlementResultDto
            {
                City = entity.City,
                Street = entity.Street,
                BuildingNo = entity.BuildingNo,
                FlatNo = entity.FlatNo,
                CreationDate = entity.CreationDate,
                LastModified = entity.LastModified == null ? null : entity.LastModified.Value,
            };
            return dto;
        }
    }
}
