using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationTest.Models.Implementation
{
    public class InMemoryRepository : IRepository
    {
        public List<Department> Departments => new List<Department>
        {
            new Department { Id = 1, Name = "R&D", Employees = new List<Employee>() },
            new Department { Id = 1, Name = "Human Resources", Employees = new List<Employee>() },
        };

        public List<Employee> Employees => new List<Employee>
        {
            new Employee { Id = 1, Name = "Dima" },
            new Employee { Id = 1, Name = "Masha" },
            new Employee { Id = 1, Name = "Sasha" },
            new Employee { Id = 1, Name = "Kirill" },
        };

        public void AssignEmployee(int employeeId, int departmentId)
        {
            //no store
        }
    }
}
