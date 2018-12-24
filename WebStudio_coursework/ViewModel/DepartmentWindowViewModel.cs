using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class DepartmentWindowViewModel
    {
        public DepartmentModel cs { get; set; }
        public DepartmentWindowViewModel(DepartmentModel c)
        {
            cs = c;
        }
    }
}
