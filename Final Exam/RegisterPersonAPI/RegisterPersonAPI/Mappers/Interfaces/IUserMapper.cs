using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.Dtos.Requests;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface IUserMapper
    {
        User Map(UserCreateRequestDto dto);
    }
}