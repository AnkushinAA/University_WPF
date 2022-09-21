using System.Windows;
using System.Windows.Controls;

namespace University_WPF.Components
{
    /// <summary>
    /// Логика взаимодействия для UserControlTwoButton.xaml
    /// </summary>
    public partial class UserControlTwoButton : UserControl
    {
        public string TextFirstButton { get; set; }
        public string TextLastButton { get; set; }
        public UserControlTwoButton()
        {
            InitializeComponent();
            DataContext = this;
        }
        public event RoutedEventHandler FirstClick;
        public event RoutedEventHandler LastClick;

       
    }
}
