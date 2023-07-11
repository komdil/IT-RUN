using Application.Abstractions.Repositories;
using Domain;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        List<Domain.Employee> _employees = new();
        public void Add(Domain.Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(Domain.Employee employee)
        {
            _employees.Remove(employee);
        }

        public IEnumerable<Domain.Employee> GetAll()
        {
            return _employees;
        }

        public void Update(Guid id, Domain.Employee employee)
        {
            var index = _employees.FindIndex(s => s.Id == id);
            _employees[index] = employee;
        }
    }
}
