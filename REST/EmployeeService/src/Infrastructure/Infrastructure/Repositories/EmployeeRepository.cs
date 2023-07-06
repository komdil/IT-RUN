using Application.Abstractions.Repositories;
using Domain;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new();
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public void Update(Guid id, Employee employee)
        {
            var index = _employees.FindIndex(s => s.Id == id);
            _employees[index] = employee;
        }
    }
}
