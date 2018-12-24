using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace WebStudio_coursework
{
    public class NoteViewModel
    {
        public NotationModel notebind { get; set; }
        public CurrentUser user { get; set; }
        public NoteViewModel(ProjectModel p, NotationModel n, CurrentUser curUser)
        {
            notebind = n;
            user = curUser;
            notebind.ID = n.ID;
            notebind.Project_ID = p.ID;
            notebind.Note = n.Note;
            notebind.Date = DateTime.Now;
            notebind.Author = user.User.ID;
            notebind.AuthorName = user.User.Name;
        }
    }
}
