using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_WPF.configurations;
using University_WPF.Model;

namespace University_WPF.ViewModels
{
    public class ViewSubjects: ViewModel
    {
        public string AllSelectStr = "SELECT * FROM cultureSubject, historySubject, matematicSubject, languageSubject, phisicsSubject" +              
               "WHERE  historySubject.StudentsId = students.Id" +
               "AND matematicSubject.StudentsId = students.Id" +
               "AND languageSubject.StudentsId = students.Id" +
               "AND phisicsSubject.StudentsId = students.Id";
        private FileConfig _fileConfig = new FileConfig();

        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> StudentList
        {
            get => _students;
            set
            {
                if (_students == value) return;
                _students = value;
                OnPropertyChanged(nameof(StudentList));
            }
        }
        public ViewSubjects()
        {
            StudentList = new ObservableCollection<Student>();
            using (var connection = new SqliteConnection(_fileConfig.ConectionStr))
            {
                connection.Open();                
                SqliteCommand command = new SqliteCommand(AllSelectStr, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine($"{reader.GetString(4)}{reader.GetString(2)}");
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

