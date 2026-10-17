using Microsoft.AspNetCore.Mvc;
using EmployeeManagementAPI.Models;

namespace EmployeeManagemnetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController: ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            Employee e1 = new Employee();
            e1.EmployeeId = 101;
            e1.Name = "Madhu";
            e1.Department = "IT";
            e1.salary = 80000;

            Employee e2 = new Employee();
            e2.EmployeeId = 102;
            e2.Name = "Anu";
            e2.Department = "IT";
            e2.salary = 76000;
            return Ok(new List<Employee> { e1, e2 });
        }
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee e)
        {
            return Ok(e);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee e)
        {
            e.EmployeeId = id;
            return Ok(e);
        }

    }
}
