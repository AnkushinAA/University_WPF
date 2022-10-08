using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace University_WPF.Windows
{
    
    public partial class ShowMarksWindow : Window
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;
        public string FullName { get { return _fullName; } }      
        
        public ShowMarksWindow(string firstName, string lastName)
        {
            InitializeComponent();
            _firstName = firstName;
            _lastName = lastName;
            _fullName = lastName+" "+_firstName;
            
        }

        private void FullScrenClick(object sender, RoutedEventArgs e)
        {

        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {

        }

        private void MinimizeClick(object sender, RoutedEventArgs e)
        {

        }

        private void ShowMarks(object sender, RoutedEventArgs e)
        {

        }
    }
}
