using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class StatusWindowViewModel
    {
        public StatusModel cs { get; set; }
        public StatusWindowViewModel(StatusModel c)
        {
            cs = c;
        }
    }
}
