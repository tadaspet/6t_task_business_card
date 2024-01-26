namespace UnitTestPracticeApplication.Services
{
    public interface IJWtService
    {
        string GetJwtToken(int userId, string username, string role);
    }
}
