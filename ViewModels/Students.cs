using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_WPF.Model;

namespace University_WPF.ViewModels
{
    public class Students : ViewModel
    {
       private ObservableCollection<Student> _students;
        public ObservableCollection<Student> StudentList
        {
            get => _students; 
            set
            {
                if(_students == value) return;
                _students = value;
                OnPropertyChanged(nameof(StudentList));
            }
        }
       
    }
}
