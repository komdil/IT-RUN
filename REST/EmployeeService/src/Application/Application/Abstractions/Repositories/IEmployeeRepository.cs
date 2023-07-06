

using Domain;

namespace Application.Abstractions.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        void Add(Employee employee);

        void Delete(Employee employee);

        void Update(Guid id, Employee employee);
    }
}
