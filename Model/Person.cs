using System;
using System.Data.Common;
using University_WPF.ViewModels;

namespace University_WPF.Model
{
    public class Person: Model
    {        
        public Person()
        {
            Adress = new Adress();
            Contact = new Contact();
        }
        private string _lastName;
        private string _firstName;
        private string _birthday;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName == value) return;
                _firstName = value;
                OnPropertyChanged(nameof(_firstName));
            }
        }
        public string LastName 
        {
            get => _lastName;
            set 
            {
                if (_lastName == value) return;
                _lastName = value;
                OnPropertyChanged(nameof(_lastName));
            }
        }
        public string Birthday
        {
            get => _birthday;
            set
            {
                if (_birthday == value) return;
                _birthday = value;
                OnPropertyChanged(nameof(_birthday));
            }
        }
        public Adress Adress { get; set; }
        public Contact Contact { get; set; }
        
    }
}
