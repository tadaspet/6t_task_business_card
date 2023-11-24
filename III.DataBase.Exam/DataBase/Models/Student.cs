using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace III.DataBase.Exam.DataBase.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public int StudentCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }
        public List<Course> Courses { get; set; }
    }
}