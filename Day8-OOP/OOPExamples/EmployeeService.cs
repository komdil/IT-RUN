using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class EmployeeService
    {
        List<Employee> allEmployees;
        public EmployeeService()
        {
            allEmployees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                allEmployees.Add(new Employee()
                {
                    Address = "Address" + i,
                    Email = $"test{i}@mail.ru",
                    Name = $"Emaployee{i}",
                    Position = $"Position{i}",
                    Salary = 100 * i
                });
            }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return allEmployees;
        }

        public IEnumerable<Employee> GetEmployees(decimal salary)
        {
            return allEmployees.Where(s => s.Salary <= salary);
        }

        public IEnumerable<Employee> GetEmployees(string position)
        {
            return allEmployees.Where(s => s.Position == position);
        }
    }
}
