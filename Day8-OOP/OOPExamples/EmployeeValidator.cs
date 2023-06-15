using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class Employee
    {
        // Name, Position и Salary, Email, Address
        public string Name { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Salary}-{Email}-{Position}";
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        public DateTime HireDate { get; set; }
    }

    public interface IEmployeeValidator
    {
        void Validate(Employee employee);
    }

    public class EmployeeValidator : IEmployeeValidator
    {
        public virtual void Validate(Employee employee)
        {
            string errorMessage = string.Empty;

            bool isEmailValid = IsEmailValid(employee, out string emailInvalidMessage);
            if (!isEmailValid)
            {
                errorMessage = emailInvalidMessage;
            }
            bool isAddressValid = IsAddressValid(employee, out string addressInvalidMessage);
            if (!isAddressValid)
            {
                errorMessage += addressInvalidMessage;
            }
            bool isSalaryValid = IsSalaryValid(employee, out string salaryInvalidMessage);
            if (!isSalaryValid)
            {
                errorMessage += salaryInvalidMessage;
            }

            if (!isEmailValid || !isAddressValid || !isSalaryValid)
            {
                throw new EmployeeValidationFailedException(errorMessage);
            }
        }

        private bool IsEmailValid(Employee employee, out string message)
        {
            message = string.Empty;
            if (!employee.Email.Contains("@"))
            {
                message = "Email must contain @";
                return false;
            }
            return true;
        }

        private bool IsAddressValid(Employee employee, out string message)
        {
            message = string.Empty;
            if (string.IsNullOrEmpty(employee.Address))
            {
                message = "Address must not be null";
                return false;
            }

            return true;
        }

        private bool IsSalaryValid(Employee employee, out string message)
        {
            message = string.Empty;
            if (employee.Salary < 100)
            {
                message = "Salary must be higher than 100";
                return false;
            }
            return true;
        }
    }

    public class ManagerValidator : EmployeeValidator
    {
        public override void Validate(Employee employee)
        {
            base.Validate(employee);
            var manager = employee as Manager;
            if (string.IsNullOrEmpty(manager.Department))
            {
                throw new EmployeeValidationFailedException("Department must not be empty or null");
            }
        }
    }

    public class EmployeeValidationFailedException : Exception
    {
        public EmployeeValidationFailedException(string message) : base(message)
        {

        }
    }
}
