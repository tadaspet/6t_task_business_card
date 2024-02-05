using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;
using RegisterPersonAPI.Dtos.Results;
using RegisterPersonAPI.Mappers.Interfaces;

namespace RegisterPersonAPI.Mappers
{
    public class PersonInfoMapper : IPersonInfoMapper
    {
        public PersonInformation Map(PersonInfoRequestDto dto, Guid userId)
        {
            var entitiy = new PersonInformation
            {
                Name = dto.Name,
                Surname = dto.Surname,
                IdentityCode = dto.IdentityCode,
                PhoneNo = dto.PhoneNo,
                Email = dto.Email,
                UserId = userId,
            };
            return entitiy;
        }
        public PersonInfoResultDto Map(PersonInformation entity)
        {
            var dto = new PersonInfoResultDto
            {
                Name = entity.Name,
                Surname = entity.Surname,
                IdentityCode = entity.IdentityCode,
                PhoneNo = entity.PhoneNo,
                Email = entity.Email,
                CreationDate = entity.CreationDate,
                LastModified = entity.LastModified == null ? DateTime.MinValue : entity.LastModified.Value,
            };
            return dto;
        }
    }
}
