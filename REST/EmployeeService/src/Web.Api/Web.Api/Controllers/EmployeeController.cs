using Application.Abstractions.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Dto;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        [HttpGet("Department/{department}")]
        public IEnumerable<Employee> GetByDepartment(string department)
        {
            return _employeeService.GetByDepartment(department);
        }

        [HttpGet("ById/{id}")]
        public Employee GetById(Guid id)
        {
            return _employeeService.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateEmployeeDto dto)
        {
            _employeeService.Create(dto.Name, dto.Salary, dto.Email, dto.UserName, dto.Password, dto.Position, dto.Department);
            return NoContent();
        }
    }
}