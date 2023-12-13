using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        // one to many relationship {Departments(1) <==> Employee(m)}
        //will take DepId as FK in Employee table so we need to do two think:
        //a) add column to DepId 
        //b) create navegation property to this id in database table 

        [ForeignKey("Departments")]   //Departments is the ==>  navigation name 
        public int? DepId { get; set; } //this is the coulmne of Fk wich is came from dep table
        public Departments? Departments { get; set; } //this is not coulomn in Employee table it is only a refrinc  only in database table //navegation property // fk هذا فقط تبع النفجيشن وليس الكولم المتخزن فيه 


        public ICollection<Projects> Projects { get; set; } = new List<Projects>();// many to many relationship {Employee(m) <==> Projects(m)}

    }
}
