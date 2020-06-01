using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using UserLoginMVC.UserLoginModal;
using UserLoginMVC.View;
using Microsoft.VisualBasic;

namespace UserLoginMVC.Controller
{
    class Controller
    {
        private static MainWindow globalMainWindowInstance;
        static void errorFunc(String msg)
        {
            MessageBox.Show("!!! " + msg + " !!!");
        }

        public void passInstanceOfThisClass(MainWindow mainWindowInstance)
        {
            globalMainWindowInstance = mainWindowInstance;
        }

        public bool tryLogin(String name, String pass)
        {
            User loser = null;
            LoginValidation validator = new LoginValidation(name, pass, errorFunc);
            if (validator.ValidateUserInput(ref loser))
            {
                globalMainWindowInstance.userName.Text = loser.Username;
                globalMainWindowInstance.userFak.Text = loser.FacNumber;


                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.ANONYMOUS:
                        globalMainWindowInstance.userRole.Text = ("anonymous");
                        break;
                    case UserRoles.ADMIN:
                        globalMainWindowInstance.userRole.Text = ("Admin");
                        break;
                    case UserRoles.INSPECTOR:
                        globalMainWindowInstance.userRole.Text = ("Inspector");
                        break;
                    case UserRoles.PROFESSOR:
                        globalMainWindowInstance.userRole.Text = ("Professor");
                        break;
                    case UserRoles.STUDENT:
                        globalMainWindowInstance.userRole.Text = ("Student");
                        break;
                    default:
                        globalMainWindowInstance.userRole.Text = ("Unregistered");
                        break;
                }

                return true;
            }
            return false;
        }

        bool IsStringOk(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '6')
                    return false;
            }

            return true;
        }

        public void changeUserRole(String numberOfRole)
        {
            if (IsStringOk(numberOfRole)) {
                int role = Convert.ToInt32(numberOfRole);
                UserRoles newRole = (UserRoles)role;
                AssignUserRole(globalMainWindowInstance.userName.Text, newRole);
            } else
            {
                MessageBox.Show("Your input is incorrect");
            }
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public void changeActiveTime(String date)
        {
            if (IsDigitsOnly(date) && date.Length == 8)
            {
                SetUserActiveTo(globalMainWindowInstance.userName.Text, DateTime.ParseExact(date, "yyyyMMdd", null));
            } else
            {
                MessageBox.Show("Your input is incorrect");
            }
           
        }
        
        public void getCurrentActivityFromButton()
        {
            Logger.GetCurrentSessionActivities();
        }
        public void displayLog()
        {
            MessageBox.Show(File.ReadAllText("Log.txt"));
        }
        public void loginCountForLast7Days()
        {
            Logger.GetLoggedInCount(globalMainWindowInstance.userName.Text);
        }
        public void displayAllUsers()
        {
            String names = " ";
            UserData ud = new UserData();
            foreach (var us in ud.TestUser)
            {
                names = names + us.Username + "\n";
            }
            MessageBox.Show(names);
        }

        public static void AssignUserRole(string name, UserRoles role)// public or private?
        {
            UserData ud = new UserData();
            foreach (var u in ud.TestUser)
            {
                if (u.Username == name)
                {
                    u.Role = role;
                    Logger.LogActivity($"Change role of {name}!");
                }
            }
        }

        public static void SetUserActiveTo(string name, DateTime newActive)// public or private?
        {
            UserData ud = new UserData();
            foreach (var u in ud.TestUser)
            {
                if (u.Username == name)
                {
                    u.ActiveTime = newActive;
                    Logger.LogActivity($"Change activity of {name}!");
                }
            }
        }
    }
}
