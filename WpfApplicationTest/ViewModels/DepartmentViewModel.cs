using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using WpfApplicationTest.Models;

namespace WpfApplicationTest.ViewModels
{
    public class DepartmentViewModel
    {
        private readonly IRepository _repository;

        public ICollectionView Departments { get; }
        public ICollectionView Employees { get; }

        public ObservableCollection<Employee> DepartmentEmployees { get; }

        public DepartmentViewModel(IRepository repository)
        {
            _repository = repository;
            Employees = new ListCollectionView(_repository.Employees);
            DepartmentEmployees = new ObservableCollection<Employee>();
            Departments = new ListCollectionView(_repository.Departments);
            Departments.CurrentChanged += SelectedDepartmentChanged;
        }

        private void SelectedDepartmentChanged(object sender, System.EventArgs e)
        {
            Department department = CurrentDepartment();
            if (department != null)
            {
                DepartmentEmployees.Clear();
                foreach (var item in department.Employees)
                {
                    DepartmentEmployees.Add(item);
                }
            }
        }


        public void AssignSelectedEmployee()
        {
            Employee employee = CurrentEmployee();
            Department department = CurrentDepartment();
            _repository.AssignEmployee(employee.Id, department.Id);
            department.Employees.Add(employee);
            DepartmentEmployees.Add(employee);
        }

        private Department CurrentDepartment()
        {
            return (Department)Departments.CurrentItem;
        }

        private Employee CurrentEmployee()
        {
            return (Employee)Employees.CurrentItem;
        }
    }
}
