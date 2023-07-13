

using Domain;

namespace Application.Abstractions.Repositories
{
    public interface IEmployeeRepository
    {
        IQueryable<Domain.Employee> GetAll();

        void Add(Domain.Employee employee);

        void Delete(Domain.Employee employee);

        void Update(Guid id, Domain.Employee employee);
    }
}
