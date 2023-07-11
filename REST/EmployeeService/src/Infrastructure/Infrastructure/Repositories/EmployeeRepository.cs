using Application.Abstractions.Repositories;
using Domain;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Add(Domain.Employee employee)
        {
            _applicationDbContext.Add(employee);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(Domain.Employee employee)
        {
            _applicationDbContext.Employees.Remove(employee);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<Domain.Employee> GetAll()
        {
            return _applicationDbContext.Employees;
        }

        public void Update(Guid id, Domain.Employee employee)
        {
            Domain.Employee employeeToUpdate = _applicationDbContext.Employees.Find(id);
            employeeToUpdate.Name = employee.Name;
            _applicationDbContext.SaveChanges();
        }
    }
}
