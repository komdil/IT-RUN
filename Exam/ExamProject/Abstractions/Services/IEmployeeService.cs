using ExamProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject.Abstractions.Services
{
    internal interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(Guid id);
        IEnumerable<Employee> GetByDepartment(string department);
        void Create(string name, decimal salary, string email, string username, string password, string position, string department);
        void Delete(Guid id);
        void Update(Guid id, string name, decimal salary, string email, string username, string password, string position, string department);
    }
}
