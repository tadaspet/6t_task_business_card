using _2._2012.IntroductionAPI.DataLayer.Models;

namespace _2._2012.IntroductionAPI.Services
{
    public interface IToDoEmailService
    {
        bool TrySendEmail(string to, TodoItem model);
    }
}
