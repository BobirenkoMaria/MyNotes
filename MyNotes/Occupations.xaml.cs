using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace MyNotes
{
    /// <summary>
    /// Логика взаимодействия для Occupations.xaml
    /// </summary>
    public partial class Occupations : Window, INotifyPropertyChanged
    {
        public Occupations()
        {
            InitializeComponent();
            DataContext = this;
        }

        private Occupation selectedOccupation;

        public Occupation SelectedOccupation
        {
            get => selectedOccupation;
            set
            {
                selectedOccupation = value;
                Signal();
            }
        }



        public ObservableCollection<Occupation> Occupation
        {
            get => Data.Occupations;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
