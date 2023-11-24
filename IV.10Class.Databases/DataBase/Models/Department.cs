using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.DataBase.Models
{
    public class Department
    {
        [Key]
        public int DepId { get; set; }
        public string DepName { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }
    }

}
