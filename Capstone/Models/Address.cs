using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Address
    {
#region constructor
        public Address() { }
#endregion
#region feilds
        public int stateid;
        public string stateName;
        public int countryid;
        public string countryName;
#endregion
#region properties
        public int StateID 
        {
            get { return stateid; }
            set { stateid = value; }
        }
        public string StateName 
        {
            get { return stateName; }
            set { stateName = value; }
        }
        public int CountryID 
        {
            get { return countryid; }
            set { countryid = value; }
        }
        public string CountryName 
        {
            get { return countryName; }
            set { countryName = value; }
        }
#endregion
#region methods
        public string GetStates() 
        {
            return "Need database!";
        }
        public string GetCountries() 
        {
            return "Need database!";
        }
#endregion
    }
}