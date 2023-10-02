using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    internal class Teacher : Person
    {
        private string Subject { get; set; }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }
        public void GetSubject()
        {
            Console.WriteLine($"Teacher: {Name}, age {Age}" +
                $"\nSubject: {Subject}");
        }
    }
}
