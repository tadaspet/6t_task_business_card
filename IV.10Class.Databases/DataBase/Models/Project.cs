using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.DataBase.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public List<Department> Departments { get; set; }
    }

}
