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

        public Description(Notes selectNotes)
        {
            InitializeComponent();
            DataContext = this;
            selectedNote = selectNotes;
        }

        private Notes selectedNote;

        

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

        public void Signal([CallerMemberName] string name = null)
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

        private void Save(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
