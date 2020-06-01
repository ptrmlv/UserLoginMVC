using System;
using System.Collections.Generic;
using System.Text;
using UserLoginMVC.UserLoginModal;

namespace UserLoginMVC.Controller
{
    class LoginValidation
    {
        public string username;
        private string password;
        private string errMessage;
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError errorAction;
        public LoginValidation(string uname, string pass, ActionOnError actionOn)
        {
            username = uname;
            password = pass;
            errorAction = actionOn;
        }
        public static UserRoles currentUserRole
        { get; private set; }
        public static string currUser
        { get; private set; }

        public static User IsUserPassCorrect(string uname, string pass)
        {
            UserData ud = new UserData();
            foreach (var us in ud.TestUser)
            {
                if (uname == us.Username && pass == us.Password)
                {
                    return us;
                }
            }
            return null;
        }


        public bool ValidateUserInput(ref User user)
        {
            try
            {
                user = IsUserPassCorrect(username, password);
                Boolean emptyUserName;
                emptyUserName = username.Equals(String.Empty);
                if (emptyUserName)
                {
                    errMessage = "Empty Username";
                    errorAction(errMessage);
                    return false;
                }
                Boolean emptyPassword;
                emptyPassword = password.Equals(String.Empty);
                if (emptyPassword)
                {
                    errMessage = "Empty Password";
                    errorAction(errMessage);
                    return false;
                }
                Boolean shortUserName;
                shortUserName = username.Length < 5;
                if (shortUserName)
                {
                    errMessage = "Username needs to be at least 5 characters!";
                    errorAction(errMessage);
                    return false;
                }
                Boolean shortPass;
                shortPass = password.Length < 5;
                if (shortPass)
                {
                    errMessage = "Password needs to be at least 5 characters! ";
                    errorAction(errMessage);
                    return false;
                }
                if (user == null)
                {
                    errMessage = "No such user exists.";
                    errorAction(errMessage);
                    currentUserRole = UserRoles.ANONYMOUS;
                    return false;
                }
                currentUserRole = (UserRoles)user.Role;
                currUser = user.Username;
                Logger.LogActivity("Successful Login");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }
    }
}
