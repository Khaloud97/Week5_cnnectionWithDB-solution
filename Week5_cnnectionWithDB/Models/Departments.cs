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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepId { get; set; }

        [Required]
        [StringLength(50,MinimumLength =15)]
        public string Name { get; set; }

        [Range(1,5)]
        public int floor { get; set; }

       

    }
}
