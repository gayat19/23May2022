using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=101,Name="Ramu",Age=21}
        };
        public IActionResult Index()
        {
            return View(employees);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var employee = employees.FirstOrDefault(emp => emp.Id == id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(int id,Employee employee)
        {
            var emp = employees.FirstOrDefault(emp => emp.Id == id);
            emp.Name = employee.Name;
            emp.Age = employee.Age;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(emp => emp.Id == id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(int id,Employee employee)
        {
            var emp = employees.FirstOrDefault(emp => emp.Id == id);
            employees.Remove(emp);
            return RedirectToAction("Index");
        }
    }
}
