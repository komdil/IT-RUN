using ExamProject.Abstractions.Repositories;
using ExamProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new();
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public void Update(Guid id, Employee employee)
        {
            var index = _employees.FindIndex(s => s.Id == id);
            _employees[index] = employee;
        }
    }
}
