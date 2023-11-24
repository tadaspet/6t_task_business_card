using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.DataBase.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        
        //navigational property for one to many
        public List<Department> Departments { get; set; }

        //navigational property for many to many
        public List<DepartmentProject> DepartmentProjects { get; set; }
        public List<EmployyeProject> EmployyeProjects { get; set; }
    }

}
