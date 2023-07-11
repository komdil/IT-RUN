using Employee.Web.Api.Contacts.Requests;
using Employee.Web.Api.Contacts.Response;

namespace Application
{
    public static class Mapper
    {
        public static IEnumerable<GetEmployeesResponse> MapEmployee(IEnumerable<Domain.Employee> employees)
        {
            return employees.Select(e => new GetEmployeesResponse()
            {
                Name = e.Name,
            });
        }

        public static GetEmployeesResponse MapEmployee(Domain.Employee employees)
        {
            return new GetEmployeesResponse()
            {
                Name = employees.Name
            };
        }
    }
}
