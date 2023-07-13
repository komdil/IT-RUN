using Application;
using Application.Abstractions.Repositories;
using Application.Abstractions.Services;
using Domain;
using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;

namespace Infrastructure.Services
{
    internal class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _repository;
        IEmailSenderService _emailSenderService;
        public EmployeeService(IEmployeeRepository employeeRepository, IEmailSenderService emailSenderService)
        {
            _repository = employeeRepository;
            _emailSenderService = emailSenderService;
        }

        public Guid Create(string name, decimal salary, string email, string username, string password, string position, string department)
        {
            var newEmployee = new Domain.Employee
            {
                Id = Guid.NewGuid(),
                Name = name,
                Salary = salary,
                Email = email,
                Department = department,
                Position = position,
                Password = password,
                UserName = username,
            };

            _repository.Add(newEmployee);
            _emailSenderService.SendEmail(email, "Welcome to company");
            return newEmployee.Id;
        }

        public void Delete(Guid id)
        {
            var employee = _repository.GetAll().FirstOrDefault(s => s.Id == id);
            if (employee != null)
            {
                _repository.Delete(employee);
            }
        }

        public IEnumerable<GetEmployeesResponse> GetAll(GetEmployeesRequest request)
        {
            IQueryable<Domain.Employee> allEmployees = _repository.GetAll();

            if (request.Department != null)
                allEmployees = allEmployees.Where(s => s.Department == request.Department);

            return Mapper.MapEmployee(allEmployees.ToList());
        }

        public IEnumerable<GetEmployeesResponse> GetByDepartment(string department)
        {
            return Mapper.MapEmployee(_repository.GetAll().Where(s => s.Department == department));
        }

        public GetEmployeesResponse GetById(Guid id)
        {
            var employee = _repository.GetAll().FirstOrDefault(s => s.Id == id);
            return Mapper.MapEmployee(employee);
        }

        public void Update(Guid id, string name, decimal salary, string email, string username, string password, string position, string department)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                var newEmployee = new Domain.Employee
                {
                    Id = id,
                    Name = name,
                    Salary = salary,
                    Email = email,
                    Department = department,
                    Position = position,
                    Password = password,
                    UserName = username,
                };
                _repository.Update(id, newEmployee);
            }
        }
    }
}
