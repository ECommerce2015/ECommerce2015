using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerAddress
    {
#region fields
        public int customerloginid;
        public string street1;
        public string street2;
        public string city;
        public string state;
        public string zip;
#endregion
#region properties
        public int CustomerLoginID 
        {
            get { return customerloginid; }
            set { customerloginid = value; }
        }
        public string Street1
        {
            get { return street1; }
            set { street2 = value; }
        }
        public string Street2
        {
            get { return street2; }
            set { street2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
#endregion
#region methods
#endregion
}