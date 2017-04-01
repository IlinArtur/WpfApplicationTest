using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationTest.Models.Implementation;

namespace WpfApplicationTest.ViewModels
{
    public class MainViewModel
    {
        public DepartmentViewModel DeparmentsViewModel { get; set; }

        public MainViewModel()
        {
            DeparmentsViewModel = new DepartmentViewModel(new InMemoryRepository());
        }
    }
}
