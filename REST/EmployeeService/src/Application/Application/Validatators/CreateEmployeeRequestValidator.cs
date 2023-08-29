using Employee.Web.Api.Contacts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validatators
{
    public class CreateEmployeeRequestValidator : AbstractValidator<CreateEmployeeDto>
    {
        public CreateEmployeeRequestValidator()
        {
            RuleFor(s => s.Email).EmailAddress();

            RuleFor(s => s.Name)
                .Must(s => s != null && s.StartsWith("employee"))
                .WithMessage("Employee Name must start with 'employee' prefix");
        }
    }
}
