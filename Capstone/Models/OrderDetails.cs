using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class OrderDetails
    {
#region constructor
        public OrderDetails() 
        {
        
        }
#endregion
#region fields
        public int orderdetailsid;
        public List<int> productid;
        public int quantity;
        public int total;
#endregion
#region properties
        public int OrderDetailID 
        {
            get { return orderdetailsid; }
            set { orderdetailsid = value; }
        }
        public List<int> ProductID 
        {
            get { return productid; }
            set { productid = value; }
        }
        public int Quantity 
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Total 
        {
            get { return total; }
            set { total = value; }
        }

#endregion
#region methods
#endregion
    }
}