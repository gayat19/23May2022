using ExampleApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApplication.Services
{
    public class EmployeeRepo : IRepo<int, Employee>
    {
        private readonly CompanyContext _context;

        public EmployeeRepo(CompanyContext context)
        {
            _context = context;
        }
        public async Task<Employee> Add(Employee item)
        {
           _context.Employees.Add(item);
            _context.SaveChanges();
            return item;
        }

        public async Task<Employee> Delete(int key)
        {
            var employee = await Get(key);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return employee;
        }

        public async Task<Employee> Get(int key)
        {
           var employee = _context.Employees.SingleOrDefault(e=>e.Id == key);
            return employee ;
        }

        public async Task<ICollection<Employee>> GetAll()
        {
            return _context.Employees.ToList();
        }

        public async Task<Employee> Update(Employee item)
        {
            var employee = await Get(item.Id);
            employee.Name=item.Name;
            employee.Salary=item.Salary;
            _context.SaveChanges();
            return employee;
        }
    }
}
