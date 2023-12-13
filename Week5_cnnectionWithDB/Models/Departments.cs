using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Week5_cnnectionWithDB.Models
{
    internal class Departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // use this when we declear the id name diffrent class id name and will Generated
        public int DepId { get; set; }

        [Required]
        [StringLength(50,MinimumLength =15)]
        public string Name { get; set; }

        [Range(1,5)]
        public int floor { get; set; }

        public ICollection<Employee> Employee { get; set; } = new List<Employee>(); // one to many relationship {Departments(1) <==> Employee(m)}

    }
}
