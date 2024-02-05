using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.BLL.Services.Interfaces
{
    public interface IJwtService
    {
        string GetJwtToken(User user);
    }
}