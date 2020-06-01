using System;
using System.Collections.Generic;
using System.Text;

namespace UserLoginMVC.UserLoginModal
{
    class User
    {

        public string Username
        { get; set; }

        public string Password
        { get; set; }
        public string FacNumber
        { get; set; }
        public UserRoles Role
        { get; set; }
        public DateTime Created
        { get; set; }
        public DateTime ActiveTime
        { get; set; }

        public User(string name, string pass, string facNum, UserRoles r, DateTime dt, DateTime active)
        {
            Username = name;
            Password = pass;
            FacNumber = facNum;
            Role = r;
            Created = dt;
            ActiveTime = active;
        }
    }
}
