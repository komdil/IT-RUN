using Domain;
using Employee.Web.Api.Contacts.Response;

namespace Application.Abstractions.Services
{
    public interface IEmployeeService
    {
        IEnumerable<GetEmployeesResponse> GetAll();
        GetEmployeesResponse GetById(Guid id);
        IEnumerable<GetEmployeesResponse> GetByDepartment(string department);
        void Create(string name, decimal salary, string email, string username, string password, string position, string department);
        void Delete(Guid id);
        void Update(Guid id, string name, decimal salary, string email, string username, string password, string position, string department);
    }
}
