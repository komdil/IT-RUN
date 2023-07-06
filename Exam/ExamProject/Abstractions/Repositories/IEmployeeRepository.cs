using ExamProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Abstractions.Repositories
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        void Add(Employee employee);

        void Delete(Employee employee);

        void Update(Guid id, Employee employee);
    }
}
