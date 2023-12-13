using Week5_cnnectionWithDB.Models;
using Week5_cnnectionWithDB.MyDbContext;

namespace Week5_cnnectionWithDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Makeen Company!");

            //******************************************** adding  using LinQ ***************************************************
            #region addData without close the connection
            //ApplicationDbContext db = new ApplicationDbContext();

            ////----------------------------------------------------------------------------------------
            ////To add data inside the table {employee}:

            //int x = 3;
            //while (x-- > 0)
            //{
            //    Console.Write("Enter Employee Name: ");
            //    string EmployeeName = Console.ReadLine();

            //    Console.Write("Enter Employee Age: ");
            //    int EmployeeAge = int.Parse(Console.ReadLine());

            //    Console.Write("Enter Employee Salary: ");
            //    decimal EmployeeSalary = decimal.Parse(Console.ReadLine());

            //    Employee emp = new Employee
            //    {
            //        EmployeeName = EmployeeName,
            //        EmployeeAge = EmployeeAge,
            //        EmployeeSalary = EmployeeSalary


            //    };

            //    db.Employees.Add(emp); //will add the value to the table Employees in database  {hapend locally}
            //    db.SaveChanges(); //save the change and update it to database {hapend locally}
            //    // db.Dispose(); // to close the connection
            //}
            #endregion

            #region with using have closing connection
            //////----------------------------------------------------------------------------------------
            ////To add data inside the table {employee} with using :

            //using ApplicationDbContext db = new ApplicationDbContext();


            //int x = 3;
            //while (x-- > 0)
            //{
            //    Console.Write("Enter Employee Name: ");
            //    string EmployeeName = Console.ReadLine();

            //    Console.Write("Enter Employee Age: ");
            //    int EmployeeAge = int.Parse(Console.ReadLine());

            //    Console.Write("Enter Employee Salary: ");
            //    decimal EmployeeSalary = decimal.Parse(Console.ReadLine());

            //    Employee emp = new Employee
            //    {
            //        EmployeeName = EmployeeName,
            //        EmployeeAge = EmployeeAge,
            //        EmployeeSalary = EmployeeSalary


            //    };

            //    db.Employees.Add(emp); //will add the value to the table Employees in database  {hapend locally}
            //    db.SaveChanges(); //save the change and update it to database {hapend locally}

            //}
            #endregion


            //******************************************** Update using LinQ ***************************************************
            #region manualy Update

            //manualy
            //using ApplicationDbContext db = new ApplicationDbContext();
            //var emp = (from E in db.Employees where E.EmployeeId ==1 select E).FirstOrDefault();
            //Console.WriteLine(emp?.EmployeeName ?? "NA");
            //emp.EmployeeName = "Hamed";
            //db.Update(emp);//will Update the value to the table Employees in database 
            //db.SaveChanges();
            #endregion

            #region Update By user 
            //By user  to (update the Name of Employee):
            Console.WriteLine("Plaese enter the id of emloyee you want to update it:");
            int id = int.Parse(Console.ReadLine());

            using ApplicationDbContext db = new ApplicationDbContext();
            var emp = (from E in db.Employees where E.EmployeeId == id select E).FirstOrDefault();
            Console.WriteLine(emp?.EmployeeName ?? "NA");
            emp.EmployeeName = "Moza";
            db.Update(emp);//will Update the value to the table Employees in database 
            db.SaveChanges();
            #endregion
        }
    }
}