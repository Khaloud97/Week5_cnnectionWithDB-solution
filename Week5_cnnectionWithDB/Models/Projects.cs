using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_cnnectionWithDB.Models
{
    internal class Projects
    {
        public int ProjectsId { get; set; }

        [MaxLength(50)]
        public string ProjectName { get; set; }

        
        public string Discription { get; set; }

        public ICollection<Employee> Employee { get; set; } = new List<Employee>();// many to many relationship {Employee(m) <==> Projects(m)}
    }
}
