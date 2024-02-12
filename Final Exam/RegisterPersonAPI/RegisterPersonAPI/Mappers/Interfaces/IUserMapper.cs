using RegisterPersonApi.DAL.Entities;
using RegisterPersonAPI.DTOs.Requests;

namespace RegisterPersonAPI.Mappers.Interfaces
{
    public interface IUserMapper
    {
        User Map(UserCreateRequestDTO dto);
    }
}