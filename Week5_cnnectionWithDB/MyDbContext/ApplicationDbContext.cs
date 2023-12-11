using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_cnnectionWithDB.Models;

namespace Week5_cnnectionWithDB.MyDbContext
{
    internal class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ENAGUK3\\MSSQLS;Initial Catalog=MakeenCompany;Integrated Security=True;");
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
