using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using University_WPF.Model;

namespace University_WPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для CreatePersonWindow.xaml
    /// </summary>
    public partial class CreateStudentWindow : Window
    {
        public Student Student {get;set;}
        public CreateStudentWindow()
        {
            InitializeComponent();
             
        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void FullScrenClick(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal) WindowState = WindowState.Maximized;
            else WindowState = WindowState.Normal;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CanselButton(object sender, RoutedEventArgs e)
        {
            PersonUC.Surname.InsertTextBox.Text = "";
            PersonUC.Name.InsertTextBox.Text = "";
            PersonUC.DateBirth.InsertTextBox.Text = "";
            PersonUC.City.InsertTextBox.Text = "";
            PersonUC.Street.InsertTextBox.Text = "";
            PersonUC.Home.InsertTextBox.Text = "";
            PersonUC.Phone.InsertTextBox.Text = "";
            PersonUC.Email.InsertTextBox.Text = "";
        }

        private void CreateStudentButton(object sender, RoutedEventArgs e)
        {
            Student.Person.FirstName = PersonUC.Surname.InsertTextBox.Text;
            Student.Person.LastName = PersonUC.Name.InsertTextBox.Text;
            Student.Person.Birthday = PersonUC.DateBirth.InsertTextBox.Text;
            Student.Person.Adress.City = PersonUC.City.InsertTextBox.Text;
            Student.Person.Adress.Street = PersonUC.Street.InsertTextBox.Text;
            Student.Person.Adress.Home = Convert.ToInt32(PersonUC.Home.InsertTextBox.Text);
            Student.Person.Contact.Phone = PersonUC.Phone.InsertTextBox.Text;
            Student.Person.Contact.Mail = PersonUC.Email.InsertTextBox.Text;
            Student.IsStudy = true;
            Hide();
        }
    }
}
