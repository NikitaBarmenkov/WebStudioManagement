using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModel;

namespace WebStudio_coursework
{
    /// <summary>
    /// Логика взаимодействия для Notes.xaml
    /// </summary>
    public partial class Notes : Window
    {
        NotesViewModel notesvm;
        public Notes(ProjectModel p, CurrentUser user)
        {
            InitializeComponent();
            notesvm = new NotesViewModel(p, user);
            DataContext = notesvm;
        }
    }
}
