using System.ComponentModel.DataAnnotations;

namespace III.DataBase.Exam.DataBase.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Time { get; set; }
        public int Credits { get; set; }
        public List<Student> Students { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}
