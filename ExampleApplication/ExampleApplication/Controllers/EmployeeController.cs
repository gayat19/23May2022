using ExampleApplication.Models;
using ExampleApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExampleApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepo<int, Employee> _repo;

        public EmployeeController(IRepo<int,Employee> repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _repo.GetAll();
            return View(result);
        }
    }
}
