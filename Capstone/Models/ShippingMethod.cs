using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class ShippingMethod
    {
#region constructor
        public ShippingMethod() 
        {
        }
#endregion
#region fields
        public int shippingmethodid;
        public string type;
        public double shippingcost;
#endregion
#region properties
        public int ShippingMethodID 
        {
            get { return shippingmethodid; }
            set { shippingmethodid = value; }
        }
        public string Type 
        {
            get { return type; }
            set { type = value; }
        }
        public double ShippingCost 
        {
            get { return shippingcost; }
            set { shippingcost = value; }
        }

#endregion
#region methods
#endregion
    }
}