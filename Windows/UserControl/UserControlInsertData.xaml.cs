using System;
using System.Windows;
using System.Windows.Controls;
namespace University_WPF.Windows.UserControl
{
    public partial class UserControlInsertData : Control    
    {
        public string? Title { get; set; }
        public UserControlInsertData()
        {
            InitializeComponent();            
        }

        public UserControlInsertData(string? title, bool contentLoaded)
        {
            Title = title;
            _contentLoaded = contentLoaded;
        }
    }
}
