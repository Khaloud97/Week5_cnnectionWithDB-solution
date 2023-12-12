using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_cnnectionWithDB.Models
{
    internal class Employee
    {
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string EmployeeName { get; set; }

        [Range(18, 50)]
        public int? EmployeeAge { get; set; }

        [DataType(DataType.Currency)]
        public decimal EmployeeSalary { get; set; }
        
    }
}
