using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using University_WPF.configurations;
using University_WPF.Model;

namespace University_WPF.ViewModels
{
    public class Students : ViewModel
    {
        public string AllSelectStr = "SELECT * FROM students " +
            "JOIN persons on persons.Id = students.PersonId";
        public FileConfig FileConfig = new FileConfig();
       
        public ObservableCollection<Student> StudentList { get; set; }
        //private Student _student;
        //public Student Student 
        //{
        //    get => _student;
        //    set
        //    {
        //        if (_student == value) return;
        //        _student = value;
        //        OnPropertyChanged();
        //    } 
        //}
        public Students()
        {
            StudentList = new ObservableCollection<Student>();
            using (var connection = new SqliteConnection(FileConfig.ConectionStr))
            {
                connection.Open();
                //SqliteCommand commandInsert = new SqliteCommand();
                //commandInsert.Connection = connection;
                //commandInsert.CommandText = "INSERT INTO students (PersonID, IsStudy)" +
                //    "VALUES (2, true)";
                //commandInsert.ExecuteNonQuery();
                SqliteCommand command = new SqliteCommand(AllSelectStr, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine($"{reader.GetString(4)}{reader.GetString(2)}");
                            Student student = new Student();
                            student.Person.LastName = reader.GetString(4);
                            student.Person.FirstName = reader.GetString(5);
                            student.Person.Birthday = reader.GetString(6);
                            student.Person.Adress.City = reader.GetString(9);
                            student.Person.Adress.Street = reader.GetString(10);
                            student.Person.Adress.Home = reader.GetInt32(11);
                            student.IsStudy = reader.GetBoolean(2);
                            student.Person.Contact.Phone = reader.GetString(7);
                            student.Person.Contact.Mail = reader.GetString(8);
                            StudentList.Add(student);
                        }
                    }
                }
            }
        }
       
    }
}
