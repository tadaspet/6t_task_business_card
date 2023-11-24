using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonelSystem.DataBase.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Proffesion { get; set; }

        public Department Department { get; set; }
        public List<Project> Projects { get; set; }

        public List<EmployyeProject> EmployyeProjects { get; set; }

    }
}
