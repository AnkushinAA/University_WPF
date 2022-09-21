using System;
using System.Collections.Generic;
using System.IO;
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
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private bool CompareAuthenticationData(string login, string password)
        {
            using var file = new StreamReader(new FileStream("Login.txt", FileMode.OpenOrCreate));
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();
                string[] str = line.Split();
                if (str[0]==login & str[1]==password)return true;
            }
            return false;
        }

        private void Button_Input_Click(object sender, RoutedEventArgs e)
        {
            if (CompareAuthenticationData(Login.Text, Passsword.Password))
            {
                new MainWindow().Show();
                this.Close();
            }
            else MessageBox.Show("Введен не правильный логин или пароль!");

        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
