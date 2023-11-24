using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static III.DataBase.Exam.Program;

namespace III.DataBase.Exam.DataBase.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string FacultyCode { get; set; }
        public string Dean { get; set; }
        public string Location { get; set; }

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
}
