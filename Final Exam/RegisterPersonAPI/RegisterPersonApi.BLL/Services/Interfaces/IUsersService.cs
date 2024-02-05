using RegisterPersonApi.DAL.Entities;

namespace RegisterPersonApi.BLL.Services.Interfaces
{
    public interface IUsersService
    {
        bool DeleteUserAndInformation(Guid userId);
        User Login(string username, string password);
        Guid Signup(User requestUser);
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
    }
}