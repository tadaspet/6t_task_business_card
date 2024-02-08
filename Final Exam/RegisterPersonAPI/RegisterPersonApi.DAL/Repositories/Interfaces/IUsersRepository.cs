using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.DAL.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        bool DeleteUserAndAllInformation(Guid userId);
        User GetUser(string userName);
        User GetUserByEmail(string email);
        User GetUserByGuid(Guid userId);
        User GetUserByUsername(string username);
        void SaveLogin(User user);
        Guid SaveUser(User user);
    }
}