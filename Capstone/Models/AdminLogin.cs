using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class AdminLogin
    {
#region constructor
        public AdminLogin() 
        {
        
        }
#endregion
#region fields
        public int adminloginid;
        public DateTime login;
        public string password;
        public int attempts;
        public string email;
        public int permissions;
#endregion
#region properties
        public int AdminLoginID
        {
            get { return adminloginid; }
            set { adminloginid = value; }
        }
        public DateTime Login 
        {
            get { return login; }
            set { login = value; }
        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
        public int Attempts 
        {
            get { return attempts; }
            set { attempts = value; }
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        public int Permissions 
        {
            get { return permissions; }
            set { permissions = value; }
        }
#endregion
#region methods
#endregion
    }
}