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

namespace UserLoginMVC.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller.Controller inter = new Controller.Controller();
        UserLoginView ulv = new UserLoginView();
        public static MainWindow AppWindow;
        public MainWindow()
        {
             InitializeComponent();
            numberRole.Visibility = System.Windows.Visibility.Collapsed;
            okRole.Visibility = System.Windows.Visibility.Collapsed;
            howTo.Visibility = System.Windows.Visibility.Collapsed;
            howTo1.Visibility = System.Windows.Visibility.Collapsed;
            date.Visibility = System.Windows.Visibility.Collapsed;
            okDate.Visibility = System.Windows.Visibility.Collapsed;
            howToDate.Visibility = System.Windows.Visibility.Collapsed;
            inter.passInstanceOfThisClass(this);
            AppWindow = this;
            ulv.Show();
            
            this.Hide();
        }

        public void namesShowButtonMVC_Click(object sender, RoutedEventArgs e)
        {
            inter.displayAllUsers();
        }

        public void displayLog_Click(object sender, RoutedEventArgs e)
        {
            inter.displayLog();
        }

        public void loginCount_Click(object sender, RoutedEventArgs e)
        {
            inter.loginCountForLast7Days();
        }
        public void changeUserRole_Click(object sender, RoutedEventArgs e)
        {
            numberRole.Visibility = System.Windows.Visibility.Visible;
            changeUserRole.Visibility = System.Windows.Visibility.Collapsed;
            okRole.Visibility = System.Windows.Visibility.Visible;
            howTo.Visibility = System.Windows.Visibility.Visible;
            howTo1.Visibility = System.Windows.Visibility.Visible;
        }
        public void okUserRole_Click(object sender, RoutedEventArgs e)
        {
           
            inter.changeUserRole(numberRole.Text);
            numberRole.Visibility = System.Windows.Visibility.Collapsed;
            changeUserRole.Visibility = System.Windows.Visibility.Visible;
            okRole.Visibility = System.Windows.Visibility.Collapsed;
            howTo.Visibility = System.Windows.Visibility.Collapsed;
            howTo1.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void currentAct_Click(object sender, RoutedEventArgs e)
        {
            inter.getCurrentActivityFromButton();
        }

        private void atChange_Click(object sender, RoutedEventArgs e)
        {
            date.Visibility = System.Windows.Visibility.Visible;
            okDate.Visibility = System.Windows.Visibility.Visible;
            atChange.Visibility = System.Windows.Visibility.Collapsed;
            howToDate.Visibility = System.Windows.Visibility.Visible;
        }

        private void okDate_Click(object sender, RoutedEventArgs e)
        {
            inter.changeActiveTime(date.Text);
            date.Visibility = System.Windows.Visibility.Collapsed;
            okDate.Visibility = System.Windows.Visibility.Collapsed;
            atChange.Visibility = System.Windows.Visibility.Visible;
            howToDate.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void date_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
