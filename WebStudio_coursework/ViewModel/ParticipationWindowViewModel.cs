using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class ParticipationWindowViewModel
    {
        public Data d { get; set; }
        DBOperations db;
        public ParticipationModel p { get; set; }
        public ParticipationWindowViewModel(ParticipationModel c)
        {
            db = new DBOperations();
            d = new Data();
            p = c;
            d.Employees = db.GetAllEmployees();
            d.Roles = db.GetAllRoles();
        }
    }
}
