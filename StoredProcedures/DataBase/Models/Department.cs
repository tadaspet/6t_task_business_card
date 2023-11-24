using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.DataBase.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepName { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }
        public List<DepartmentProject> DepartmentProjects { get; set; } 
    }

}
