using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModel;

namespace WebStudio_coursework
{
    public class NotesViewModel
    {
        DBOperations db;
        public Data d { get; set; }
        public ProjectModel Pr { get; set; }
        public CurrentUser user { get; set; }
        public NotationModel sel_note { get; set; }
        public List<NotationModel> noteslist { get; set; }
        public RelayCommand add_note { get; set; }
        public RelayCommand edit_note { get; set; }
        public RelayCommand del_note { get; set; }
        public NotesViewModel(ProjectModel p, CurrentUser curUser)
        {
            d = new Data();
            db = new DBOperations();
            user = curUser;
            d.Notations = db.GetAllNotations(p.ID);
            add_note = new RelayCommand(addNote);
            edit_note = new RelayCommand(editNote);
            del_note = new RelayCommand(delNote);
            db = new DBOperations();
            Pr = p;
        }
        private void addNote(object sender)
        {
            NotationModel newnote = new NotationModel();
            Note n = new Note(Pr, newnote, user);

            if (n.ShowDialog() == true)
            {
                db.AddNotation(newnote);
                db.Save();
                d.Notations = db.GetAllNotations(Pr.ID);
            }
        }
        private void editNote(object sender)
        {
            if (sel_note != null)
            {
                NotationModel newnote = db.GetNotation(sel_note.ID);
                if (newnote.Author == user.User.ID)
                {
                    Note n = new Note(Pr, newnote, user);
                    if (n.ShowDialog() == true)
                    {
                        db.UpdateNotation(newnote);
                        db.Save();
                        d.Notations = db.GetAllNotations(Pr.ID);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не можете редактировать чужую запись!");
                }
            }
        }
        private void delNote(object sender)
        {
            if (sel_note != null)
            {
                NotationModel newnote = db.GetNotation(sel_note.ID);
                if (newnote.Author == user.User.ID)
                {
                    db.DeleteNotation(newnote);
                    db.Save();
                    d.Notations = db.GetAllNotations(Pr.ID);
                }
                else
                {
                    MessageBox.Show("Вы не можете удалить чужую запись!");
                }
            }
        }
    }
}
