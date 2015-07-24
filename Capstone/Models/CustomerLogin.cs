using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerLogin
    {
#region
        public CustomerLogin()
        {
        }
#endregion
#region fields
        public List<Int16> customerloginid;
        public DateTime login;
        public string password;
        public DateTime created;
        public DateTime updated;
#endregion
#region properties
        public List<Int16> CustomerLoginID
        {
            get { return customerloginid; }
            set { customerloginid = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }
        public DateTime Updated
        {
            get { return updated; }
            set { updated = value; }
        }
#endregion
#region methods
#endregion
    }
}