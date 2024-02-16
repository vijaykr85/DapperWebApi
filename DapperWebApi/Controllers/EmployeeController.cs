using DapperWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _employeeService.GetEmployee();

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var result = await _employeeService.GetEmployee();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            var result = await _employeeService.CreateEmployee(employee);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee([FromBody] Employee employee)
        {
            var result = await _employeeService.UpdateEmployee(employee);

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);

            return Ok(result);
        }
    }
}
