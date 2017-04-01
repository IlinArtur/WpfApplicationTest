using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationTest.ViewModels;

namespace WpfApplicationTest.Commands
{
    public class AssignEmployeeCommand: CommandBase<DepartmentViewModel>
    {
        protected override void Execute(DepartmentViewModel view)
        {
            view.AssignSelectedEmployee();
        }
    }
}
