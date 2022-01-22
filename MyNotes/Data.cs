using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MyNotes
{
    static class Data
    {
        public static ObservableCollection<Notes> Notes = new ObservableCollection<Notes>();
        public static ObservableCollection<Occupation> Occupations = new ObservableCollection<Occupation>();
    }
}
