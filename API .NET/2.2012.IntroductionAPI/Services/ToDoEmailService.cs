using _2._2012.IntroductionAPI.DataLayer.Models;

namespace _2._2012.IntroductionAPI.Services
{
    public class ToDoEmailService : IToDoEmailService
    {
        public bool TrySendEmail(string to, TodoItem model)
        {
            //kazkokia email siuntimo logika
            Console.WriteLine($"El. pastas issiustas {to}");
            return true;
        }
    }
}
