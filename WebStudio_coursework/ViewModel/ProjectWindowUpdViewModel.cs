using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace WebStudio_coursework
{
    public class ProjectWindowUpdViewModel
    {
        DBOperations db;
        public Data d1 { get; set; }
        public ProjectModel Pr { get; set; }
        public CurrentUser user { get; set; }
        public ParticipationModel sel_part { get; set; }
        public RelayCommand add_participation { get; set; }
        public RelayCommand edit_participation { get; set; }
        public RelayCommand del_participation { get; set; }
        public RelayCommand JournalClick { get; set; }
        public ProjectWindowUpdViewModel(ProjectModel p, CurrentUser curUser)
        {
            db = new DBOperations();
            d1 = new Data();
            add_participation = new RelayCommand(AddParticipation);
            edit_participation = new RelayCommand(EditParticipation);
            del_participation = new RelayCommand(DeleteParticipation);
            JournalClick = new RelayCommand(ShowJournal);
            Pr = p;
            user = curUser;
            d1.Services = db.GetAllServices();
            d1.Employees = db.GetAllEmployees();
            d1.Participations = db.GetAllParticipations(p.ID);
            d1.Customers = db.GetAllCustomers();
            d1.Statuses = db.GetAllStatuses();
            d1.Roles = db.GetAllRoles();
        }

        private void AddParticipation(object obj)
        {
            sel_part = new ParticipationModel();
            ParticipationWindow cw = new ParticipationWindow(sel_part);

            if (cw.ShowDialog() == true)
            {
                sel_part.Project_ID = Pr.ID;
                db.AddParticipation(sel_part);
                db.Save();
                d1.Participations = db.GetAllParticipations(Pr.ID);
            }
        }

        private void EditParticipation(object obj)
        {
            if (sel_part != null)
            {
                ParticipationWindow cw = new ParticipationWindow(sel_part);

                if (cw.ShowDialog() == true)
                {
                    db.UpdateParticipation(sel_part);
                    db.Save();
                    d1.Participations = db.GetAllParticipations(Pr.ID);
                }
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void DeleteParticipation(object sender)
        {
            if (sel_part != null)
            {
                db.DeleteParticipation(sel_part);
                db.Save();
                d1.Participations = db.GetAllParticipations(Pr.ID);
            }
            else { MessageBox.Show("Вы ничего не выбрали!"); }
        }

        private void ShowJournal(object sender)
        {
            Notes n = new Notes(Pr, user);
            n.ShowDialog();
        }
    }
}
