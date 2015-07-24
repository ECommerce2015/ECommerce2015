using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Customer
    {
        #region constructor
        public Customer() { 
                                
        }
#endregion
#region fields
        public int customerid;          
        public string firstname;
        public string lastname;
        public string email;
        public string phone;        
#endregion
#region properties
        public int CustomerID 
        {
            get { return customerid; }
            set { customerid = value; }
        }
        
        public string FirstName 
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName 
        {
            get { return lastname; }
            set { lastname = value; } 
        }
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone 
        {
            get { return phone; }
            set { phone = value; }
        }
       
#endregion
#region methods
#endregion
    }
}