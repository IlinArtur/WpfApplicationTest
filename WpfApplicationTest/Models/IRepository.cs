using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationTest.Models
{
    public interface IRepository
    {
        List<Employee> Employees { get; }
        List<Department> Departments { get; }
        void AssignEmployee(int employeeId, int departmentId);
    }
}
