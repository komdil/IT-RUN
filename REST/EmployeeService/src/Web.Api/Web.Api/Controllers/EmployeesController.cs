using Application.Abstractions.Services;
using Domain;
using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Dto;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IEnumerable<GetEmployeesResponse> Get([FromQuery] GetEmployeesRequest request)
        {
            return _employeeService.GetAll();
        }

        [HttpGet("{id}")]
        public GetEmployeesResponse Get(Guid id)
        {
            return _employeeService.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateEmployeeDto dto)
        {
            var createdId = _employeeService.Create(dto.Name, dto.Salary, dto.Email, dto.UserName, dto.Password, dto.Position, dto.Department);
            return Created($"Employees/{createdId}", null);
        }

        [HttpPut("{id}")]
        public GetEmployeesResponse Put(Guid id)
        {
            return _employeeService.GetById(id);
        }
    }
}