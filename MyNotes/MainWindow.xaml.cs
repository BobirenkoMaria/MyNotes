﻿using System;
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
        private Notes selectNote;

        public ObservableCollection<Notes> Notes
        {
            get => Data.Notes;
        }

        public ObservableCollection<Notes> SelectNotes
        {
            get => selectNote;
            set
            {
                selectNote = value;
                Signal();
            }
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenDescription(object sender, MouseButtonEventArgs e)
        {
            Description win = new Description();
            win.ShowDialog();
        }
    }
}