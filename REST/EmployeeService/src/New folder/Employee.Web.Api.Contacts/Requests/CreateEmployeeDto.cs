using System.ComponentModel.DataAnnotations;

namespace Employee.Web.Api.Contacts
{
    public record CreateEmployeeDto
    {
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
