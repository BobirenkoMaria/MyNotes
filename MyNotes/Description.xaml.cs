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
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace MyNotes
{
    /// <summary>
    /// Логика взаимодействия для Description.xaml
    /// </summary>
    public partial class Description : Window, INotifyPropertyChanged
    {
        public Description()
        {
            InitializeComponent();
            DataContext = this;
        }

        private Notes selectedNote;

        public ObservableCollection<Notes> Notes
        {
            get => Data.Notes;
        }

        public Notes SelectedNote
        {
            get => selectedNote;
            set
            {
                selectedNote = value;
                Signal();
            }
        }
        public ObservableCollection<Occupation> Occupations
        {
            get => Data.Occupations;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OpenOccupation(object sender, RoutedEventArgs e)
        {
            Occupations win = new Occupations();
            win.ShowDialog();
        }
    }
}
