using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Services
    {
#region constructor
        public Services() 
        {
        }
#endregion
#region fields
        public int serviceid;
        public List<int> categoryid;
        public string name;
        public string description;
#endregion
#region properties
        public int ServiceID 
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
        public List<int> CategoryID 
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Description 
        {
            get { return description; }
            set { description = value; }
        }
#endregion
#region methods
#endregion
    }
}