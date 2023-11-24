using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.DataBase.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int DepId { get; set; }
        public Department Department { get; set; }
        public List<Project> Projects { get; set; }
    }

}
