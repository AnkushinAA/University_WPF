using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace University_WPF.Components
{   
    public partial class UserControlInsertData : UserControl
    {
        public string TitleUC { get; set; } 
        public static DependencyProperty TextBoxUCProperty = DependencyProperty.Register("TextBlockUC",typeof(TextBox), typeof(UserControlInsertData), new PropertyMetadata());
        public string TextUC { get; set; }
        public TextBlock TextBoxUC 
        {
            get
            {
                return (TextBlock)GetValue(TextBoxUCProperty);
            }
            set
            {
                SetValue(TextBoxUCProperty, value);
            }
        }
        public UserControlInsertData()
        {
            InitializeComponent();
            this.DataContext = this;
        }
       
    }
}
