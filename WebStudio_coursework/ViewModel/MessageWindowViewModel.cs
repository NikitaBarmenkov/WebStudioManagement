using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class MessageWindowViewModel
    {
        public Data d { get; set; }
        DBOperations db;
        public CurrentUser user { get; set; }
        public MessageModel mes { get; set; }
        public MessageWindowViewModel(MessageModel m, CurrentUser user)
        {
            d = new Data();
            this.user = user;
            db = new DBOperations();
            d.Employees = db.GetAllEmployees();
            mes = m;
            mes.Date = DateTime.Now;
        }
    }
}
