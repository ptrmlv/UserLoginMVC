using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLoginMVC.Controller;

namespace UserLoginMVC
{
   
    public partial class UserLoginView : Window
    {
        private Controller.Controller inter = new Controller.Controller();
        public UserLoginView()
        {
            InitializeComponent();
        }
        public void LogButtonMVC_Click(object sender, RoutedEventArgs e)
        {
           if( inter.tryLogin(textUsername.Text, textPassword.Text))
            {
                this.Close();
                View.MainWindow.AppWindow.Show();
            }
        }
    }
}
