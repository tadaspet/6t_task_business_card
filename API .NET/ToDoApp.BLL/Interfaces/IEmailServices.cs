namespace ToDoApp.BLL.Interfaces
{
    public interface IEmailServices
    {
        public void SendEmail(string to, string subject, string body)
    }
}