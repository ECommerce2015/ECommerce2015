using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Register
    {
#region constructor
        public Register() { }
#endregion
#region feilds
        public int userid;
        public string userName;
        public string companyName;
        public string email;
        public string password;
        public string address;
        public int statedID;
        public int countryID;
        public string city;
        public int code;
        public int number;
#endregion
#region properties
        public int UserID 
        {
            get { return userid; }
            set { userid = value; }
        }
        public string StateName 
        {
            get { return userName; }
            set { userName = value; }
        }
        public string CompanyName 
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password 
        {
            get { return password; }
            set { password = value; }
        }
        public string Address 
        {
            get { return address; }
            set { address = value; }
        }
        public int StateID 
        {
            get { return statedID; }
            set { statedID = value; }
        }
        public int CountryID 
        {
            get { return countryID; }
            set { countryID = value; }
        }
        public string City 
        {
            get { return city; }
            set { city = value; }
        }
        public int Code 
        {
            get { return code; }
            set { code = value; }
        }
        public int Number 
        {
            get { return number; }
            set { number = value; }
        }
#endregion
#region methods
        public string GetStates() 
        {
            return "Need database!";
        }
#endregion
    }
}