namespace Employee.Web.Api.Contacts.Requests
{
    public record GetEmployeesRequest
    {
        public string Department { get; init; }

        public string OrderBy { get; init; }
    }
}
