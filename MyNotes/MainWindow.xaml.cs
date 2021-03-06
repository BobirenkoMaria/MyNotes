using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyNotes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        private Notes selectNotes;

        public ObservableCollection<Notes> Notes
        {
            get => Data.Notes;
        }

        public Notes SelectNotes
        {
            get => selectNotes;
            set
            {
                selectNotes = value;
                Signal();
            }
        }

        public void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddNote(object sender, RoutedEventArgs e)
        {
            Notes.Add(new Notes
            {
                Name = "Новая задача"
            });
        }
        
        private void OpenDescription(object sender, MouseButtonEventArgs e)
        {
            Description win = new Description(SelectNotes);
            win.ShowDialog();
        }

        private void DeleteNote(object sender, RoutedEventArgs e)
        {
            if (SelectNotes == null)
                return;
            if (MessageBox.Show("Действительно удалить выбраную задачу?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Notes.Remove(SelectNotes);
                SelectNotes = null;
            }
        }
    }
}
