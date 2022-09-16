using System.Data.Common;

namespace University_WPF.Model
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public Data birthday;
        public Adress adress;
        public Contact contactPerson;
        public Person(string firstName, string lastName, Data birthday, Adress adress, Contact contactPerson)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.adress = adress;
            this.contactPerson = contactPerson;
        }

        public class Data
        {
            public int day;
            public int month;
            public int year;
            public Data(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }

        public class Adress
        {
            public string city;
            public string street;
            public int home;
            public Adress(string city, string street, int home)
            {
                this.city = city;
                this.street = street;
                this.home = home;
            }
        }

        public class Contact
        {
            public string phone;
            public string mail;
            public Contact(string phone, string mail)
            {
                this.phone = phone;
                this.mail = mail;
            }
        }
    }
}
