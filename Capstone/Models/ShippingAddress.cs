using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class ShippingAddress
    {
#region constructor
        public ShippingAddress() 
        {
        }   
#endregion
#region fields
        public int shippingaddressid;
        public List<int> customerid;
        public List<int> customeraddressid;
        public string name;
        public string street1;
        public string street2;
        public string city;
        public string state;
        public string zip;
#endregion
#region properties
        public int ShippingAddressID 
        {
            get { return shippingaddressid; }
            set { shippingaddressid = value; }
        }
        public List<int> CustomerID 
        {
            get { return customerid; }
            set { customerid = value; }
        }
        public List<int> CustomerAddressID 
        {
            get { return customeraddressid; }
            set { customeraddressid = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
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
#endregion
#region methods
#endregion
    }
}