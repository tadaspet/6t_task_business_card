using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Dtos.Results;
using RegisterPersonAPI.Mappers.Interfaces;

namespace RegisterPersonAPI.Mappers
{
    public class SettlementMapper : ISettlementMapper
    {
        public Settlement Map(SettlementRequestDto Dto)
        {
            var entity = new Settlement
            {
                City = Dto.City,
                Street = Dto.Street,
                BuildingNo = Dto.BuildingNo,
                FlatNo = Dto.FlatNo == null ? null : Dto.FlatNo.ToString(),
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
