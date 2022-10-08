using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace University_WPF.Model
{
    public class Student: Model 
    {
        private Person _person;

        public Person Person 
        {
            get => _person;
            set
            {
                if (_person == value) return;
                _person = value;
                OnPropertyChanged(nameof(_person));
            }
        }
        public bool IsStudy { get; set; }

        public Dictionary<string, List<int>> Marks { get; set; }
        public Student()
        {
            IsStudy = true;
            List<int> list = new List<int>();
            Marks = new Dictionary<string, List<int>>();
            foreach (string str in Subjects.subjects)
            {
                Marks.Add(str, list);
            } 
            Person = new Person();
        }
                

       

       
    }
}
