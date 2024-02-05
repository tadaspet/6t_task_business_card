namespace TestingNotesApiBLL.Interfaces
{
    public interface IJwtService
    {
        public string GetJwtToken(string userName, int userId);
    }
}