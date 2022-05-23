using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApplication.Controllers
{
    public class SampleController : Controller
    {
        static List<Employee> employees = new List<Employee>();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployeeView()
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Ramu";
            employee.Age = 21;
            ViewBag.emp = employee;
            ViewData["name"] = "Bimu";
            TempData["username"]=employee.Name;
            return View(employee);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("ShowEmployees");
        }
        public ActionResult ShowEmployees()
        {
            return View(employees);
        }
    }
}
