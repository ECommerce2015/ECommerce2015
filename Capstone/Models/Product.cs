using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Product
    {
#region constructor
        public Product() { 
            
        }
#endregion
#region fields
        public int productid;
        public List<Int16> categoryid;
        public List<Int16> productstatusid;
        public string productname;
        public string description;
        public float price;
        public int quantity;
        public string images;
#endregion
#region properties
        public int ProductId 
        {
            get { return productid; }
            set { productid = value; }
        }
        public List<Int16> CategoryID
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        public List<Int16> ProductStatusID
        {
            get { return productstatusid; }
            set { productstatusid = value; }
        }
        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public float Price 
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Image
        {
            get { return images; }
            set { images = value; }
        }
#endregion
#region methods

#endregion
    }
}