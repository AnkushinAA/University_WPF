using System;
using System.Data.Common;

namespace University_WPF.Model
{
    public class Person
    {
        private Adress adress;

        public Person(string firstName, string lastName, DateTime birthday, Adress adress, Contact contactPerson)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            this.adress = adress;
            ContactPerson = contactPerson;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public Adress AdressPerson { get; set; }
        public Contact ContactPerson { get; set; }
        
        public class Adress
        {
            public string City { get; set; }
            public string Street { get; set; }
            public int Home { get; set; }
           
        }

        public class Contact
        {
            public string Phone { get; set; }
            public string Mail { get; set; }
           
        }
    }
}
