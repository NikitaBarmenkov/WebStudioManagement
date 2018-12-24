using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class CustomerWindowViewModel
    {
        public CustomerModel cs { get; set; }
        public CustomerWindowViewModel(CustomerModel c)
        {
            cs = c;
            cs.ID = c.ID;
            cs.Name = c.Name;
            cs.Phone = c.Phone;
            cs.Email = c.Email;
        }
    }
}
