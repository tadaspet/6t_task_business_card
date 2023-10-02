using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    internal class Student : Person
    {
        private string StudentId { get; set; }

        public Student(string name, int age, string id) : base(name,age)
        {
            StudentId = id;
        }
        public string GetStudentId() 
        {
            return StudentId; 
        }
    }
}
