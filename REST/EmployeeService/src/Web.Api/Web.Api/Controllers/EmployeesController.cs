using Application.Abstractions.Services;
using Application.Validatators;
using Domain;
using Employee.Web.Api.Contacts;
using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;
using FluentValidation.Results;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly CreateEmployeeRequestValidator _validator;
        public EmployeesController(IEmployeeService employeeService, ApplicationDbContext context, CreateEmployeeRequestValidator createEmployeeRequestValidator)
        {
            _employeeService = employeeService;
            _validator = createEmployeeRequestValidator;
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
            //Task.Delay(20000).Wait();
            return _employeeService.GetAll(request);
        }

        [HttpGet("{id}")]
        public GetEmployeesResponse Get(Guid id)
        {
            return _employeeService.GetById(id);
        }

        //  [Authorize(Roles = "superadmin")]
        [HttpPost]
        public IActionResult Post([FromBody] CreateEmployeeDto dto)
        {
            ValidationResult validationResult = _validator.Validate(dto);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var createdId = _employeeService.Create(dto.Name, dto.Salary, dto.Email, dto.UserName, dto.Password, dto.Position, dto.Department);
            return Created($"Employees/{createdId}", null);
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public GetEmployeesResponse Put(Guid id)
        {
            return _employeeService.GetById(id);
        }
    }
}