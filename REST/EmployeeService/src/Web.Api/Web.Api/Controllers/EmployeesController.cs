using Application.Abstractions.Services;
using Domain;
using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Dto;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService, ApplicationDbContext context)
        {
            _employeeService = employeeService;

            if (!context.Employees.Any())
            {
                var newContact = new Contact()
                {
                    Id = Guid.NewGuid(),
                    Address = "some",
                    City = "st",
                    Country = "c",
                    Fax = "f",
                    Phone = "f",
                    PostalCode = "f",
                    Region = "f",

                };
                var newEmployee = new Domain.Employee
                {
                    Name = "SomeName",
                    Email = "test@mail.ru",
                    Id = Guid.NewGuid(),
                    Department = "d",
                    Password = "p",
                    Position = "p",
                    Salary = 100,
                    UserName = "u",
                    Contact = newContact
                };
                context.Contact.Add(newContact);
                context.Employees.Add(newEmployee);
                context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<GetEmployeesResponse> Get([FromQuery] GetEmployeesRequest request)
        {
            return _employeeService.GetAll(request);
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