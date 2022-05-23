using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConnectApp.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext():base(@"Data source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial catalog=dbSample29Mar22")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
