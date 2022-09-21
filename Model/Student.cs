using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace University_WPF.Model
{
    public class Student : Person
    {
        public Student( string firstName, string lastName, DateTime birthday, Adress adress, Contact contactPerson) : base(firstName, lastName, birthday, adress, contactPerson)
        {
            IsStudy = true;
            List<int> list = new List<int>();
            Marks = new Dictionary<string, List<int>>();
            foreach ( string str in Subjects.subjects)
            {
                Marks.Add(str, list);
            }
        }
                

        public bool IsStudy { get; set; }
        
        public Dictionary<string,List<int>> Marks { get; set; }

       
    }
}
