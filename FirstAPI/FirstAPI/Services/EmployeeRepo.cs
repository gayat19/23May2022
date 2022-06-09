using FirstAPI.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Services
{
    public class EmployeeRepo : IRepo<int, Employee>
    {
        private readonly CompanyContext _context;
        private readonly ILogger<EmployeeRepo> _logger;

        public EmployeeRepo(CompanyContext context,ILogger<EmployeeRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task<Employee> Add(Employee item)
        {
            try
            {
                _context.Employees.Add(item);
                _context.SaveChangesAsync().Wait();
                return item;
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<Employee> Delete(int key)
        {
            try
            {
                var emp = await Get(key);
                if(emp != null)
                {
                    _context.Employees.Remove(emp);
                    _context.SaveChangesAsync();
                    return emp;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<Employee> Get(int key)
        {
            try
            {
                var emp = _context.Employees.FirstOrDefault(emp => emp.Id == key);
                if(emp != null)
                    return emp;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<ICollection<Employee>> GetAll()
        {
            try
            {
                var employees = _context.Employees;
                if (employees.Count() != 0)
                {
                    return employees.ToList();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public async Task<Employee> Update(Employee item)
        {
            try
            {
                var emp = await Get(item.Id);
                if (emp != null)
                {
                    emp.Name = item.Name;
                    emp.Age = item.Age;
                    emp.DepartmentId = item.DepartmentId;
                    _context.SaveChangesAsync();
                    return emp;
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }
    }
}
