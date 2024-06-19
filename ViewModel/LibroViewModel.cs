using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel
{
    public class LibroViewModel:INotifyPropertyChanged
    {
        private Libro _libro;
        public Libro Libro { 
        get { return _libro; }
            set { _libro = value;
                OnPropertyChanged(nameof(Libro));
            }
        }
        public List<Libro> Libros { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyname)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
    
}
