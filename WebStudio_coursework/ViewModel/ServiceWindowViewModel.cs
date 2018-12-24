using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class ServiceWindowViewModel
    {
        public ServiceModel cs { get; set; }
        public ServiceWindowViewModel(ServiceModel c)
        {
            cs = c;
        }
    }
}
