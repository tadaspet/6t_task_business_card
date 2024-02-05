using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        bool DeleteUserAndAllInformation(Guid userId);
        User GetUser(string userName);
        User GetUserByGuid(Guid userId);
        void SaveLogin(User user);
        Guid SaveUser(User user);
    }
}