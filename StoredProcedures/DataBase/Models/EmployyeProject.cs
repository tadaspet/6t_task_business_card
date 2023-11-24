using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem.DataBase.Models
{
    public class EmployyeProject
    {
        [Key]
        public int ProjectId { get; set; }
        [Key]
        public int EmployeeId { get; set; }
        public Project Project { get; set; }
        public Employee Employee { get; set; }
    }
}
