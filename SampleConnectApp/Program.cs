using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using SampleConnectApp.Models;

namespace SampleConnectApp
{
    class Program
    {
        CompanyContext context;
        Program()
        {
            context = new CompanyContext();
            
        }
        void InsertEmployee()
        {
            Department department = new Department();
            department.Id = 1;
            department.DepartmentName = "Operations";
            context.Departments.Add(department);
            context.SaveChanges();
            Employee employee = new Employee();
            employee.Empid = 101;
            employee.Name = "Ramu";
            employee.Age = 22;
            employee.Salary = 12345.4f;
            employee.DepartmentId = 1;
            context.Employees.Add(employee);
            context.SaveChanges();
            Console.WriteLine("Employee Added");
        }
        static void Main(string[] args)
        {
            Program program =new Program();
            program.InsertEmployee();
            Console.ReadKey();
        }
    }
}
