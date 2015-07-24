using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class SubCategory
    {
#region constructor
        public int subcategoryid;
        public string name;
        public string description;
#endregion
#region fields
        public int SubCategoryID 
        {
            get { return subcategoryid; }
            set { subcategoryid = value; }
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
#region properties
#endregion
#region methods
#endregion
    }
}