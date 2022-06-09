using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("myCors")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepo<int, Employee> _repo;

        //static List<Employee> employees = new List<Employee>
        //{
        //    new Employee { Id = 1,Name ="Ramu",Age =21},
        //    new Employee { Id = 2,Name ="Somu",Age =32}
        //};
        public EmployeeController(IRepo<int,Employee> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Employee>>> Get()
        {
            var employees = await _repo.GetAll();
           if(employees == null)
                return NotFound();
            return Ok(employees);
        }
        [HttpGet]
        [Route("GetEmployee")]
        public async Task<ActionResult<Employee>> GetById([FromBody]int id)
        {
            //var employee = employees.FirstOrDefault(e => e.Id == id);
            //return employee;
            var employee = await _repo.Get(id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }
        [HttpPost]
        public async Task<ActionResult<Employee>>  Post(Employee emp)
        {
            //employees.Add(emp);
            //return emp;
            var employee = await _repo.Add(emp);
            if (employee == null)
                return BadRequest();
            return Created("Employee Added",employee);
        }
        [HttpPut]
        public async Task<ActionResult<Employee>> Put(int id,Employee emp)
        {
            //var employee = employees.FirstOrDefault(e => e.Id == id);
            //if (employee == null)
            //    return null;
            //employee.Name = emp.Name;
            //employee.Age = emp.Age;
            //return employee;
            var employee = await _repo.Update(emp);
            if (employee == null)
                return BadRequest();
            return Ok(employee);
        }
        [HttpDelete]
        public async Task<ActionResult<Employee>> Delete(int id)
        {
            //var employee = employees.FirstOrDefault(e => e.Id == id);
            //if (employee == null)
            //    return null;
            //employees.Remove(employee);
            //return employee;
            var employee = await _repo.Delete(id);
            if (employee == null)
                return BadRequest();
            return Ok(employee);
        }
    }
}
