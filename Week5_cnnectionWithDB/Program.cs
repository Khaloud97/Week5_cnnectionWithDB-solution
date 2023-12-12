using Week5_cnnectionWithDB.Models;
using Week5_cnnectionWithDB.MyDbContext;

namespace Week5_cnnectionWithDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Makeen Company!");
            ApplicationDbContext db = new ApplicationDbContext();

            //----------------------------------------------------------------------------------------
            //To add data inside the table {employee}:
            int x = 3;
            while (x-- > 0)
            {
                Console.Write("Enter Employee Name: ");
                string EmployeeName = Console.ReadLine();

                Console.Write("Enter Employee Age: ");
                int EmployeeAge = int.Parse( Console.ReadLine());

                Console.Write("Enter Employee Salary: ");
                decimal EmployeeSalary = decimal.Parse(Console.ReadLine());

                Employee emp = new Employee
                {
                    EmployeeName = EmployeeName,
                    EmployeeAge = EmployeeAge,
                    EmployeeSalary = EmployeeSalary


                };

                db.Employees.Add(emp); //will add the value to database
                db.SaveChanges(); //save the change and update it to database
            }
           

        }
    }
}