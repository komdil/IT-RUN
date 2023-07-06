using ExamProject.Abstractions.Repositories;
using ExamProject.Abstractions.Services;
using ExamProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Services
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

        public void Create(string name, decimal salary, string email, string username, string password, string position, string department)
        {
            var newEmployee = new Employee
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
        }

        public void Delete(Guid id)
        {
            var employee = _repository.GetAll().FirstOrDefault(s => s.Id == id);
            if (employee != null)
            {
                _repository.Delete(employee);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Employee> GetByDepartment(string department)
        {
            return _repository.GetAll().Where(s => s.Department == department);
        }

        public Employee GetById(Guid id)
        {
            return _repository.GetAll().FirstOrDefault(s => s.Id == id);
        }

        public void Update(Guid id, string name, decimal salary, string email, string username, string password, string position, string department)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                var newEmployee = new Employee
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
