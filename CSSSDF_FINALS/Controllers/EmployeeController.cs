using CSSSDF_FINALS.Managers;
using CSSSDF_FINALS.Models;

using Microsoft.AspNetCore.Mvc;

namespace CSSSDF_FINALS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly Service _service;

        public EmployeeController(Service service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Ok(_service.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = _service.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            _service.AddEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.EmployeeId }, employee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var existingEmployee = _service.GetEmployeeById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            _service.UpdateEmployee(id, employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee_to_delete = _service.GetEmployeeById(id);
            if (employee_to_delete == null)
            {
                return NotFound();
            }
            _service.DeleteEmployee(id);
            return NoContent();
        }
    }
}
