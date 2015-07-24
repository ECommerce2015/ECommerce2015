using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Category
    {
#region constructor
        public Category() { }
#endregion
#region fields
        public int categoryid;
        public List<int> adminloginid;
        public List<int> subcategoryid;
        public string name;
        public string description;
#endregion
#region properties
        public int CategoryID
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        public List<int> AdminLoginID 
        {
            get { return adminloginid; }
            set { adminloginid = value; }
        }
        public List<int> SubCategoryID 
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
#region methods
#endregion
    }
}