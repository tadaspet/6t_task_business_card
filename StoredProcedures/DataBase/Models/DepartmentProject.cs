using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem.DataBase.Models
{
    public class DepartmentProject
    {
        [Key]
        public int DepartmentId { get; set; }
        [Key]
        public int ProjectId { get; set; }
        public Department Department { get; set; }
        public Project Project { get; set; }
    }
}
