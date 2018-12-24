using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class RoleWindowViewModel
    {
        public RoleModel cs { get; set; }
        public RoleWindowViewModel(RoleModel c)
        {
            cs = c;
        }
    }
}
