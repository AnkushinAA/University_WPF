using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using University_WPF.Model;
using University_WPF.ViewModels;

namespace University_WPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void ShowMarks(object sender, RoutedEventArgs e)
        {
            var person = ((Student)StudentsData.SelectedItem).Person;
            new ShowMarksWindow(person.LastName, person.FirstName).Show();           
            
        }

        private void CreateStudentButton(object sender, RoutedEventArgs e)
        {          
            var a = new CreateStudentWindow();
            a.Show();
            if (a.Student !=null) StudentsData.Items.Add(a.Student);
            
            
        }
    }
}
