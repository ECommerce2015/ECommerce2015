using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class OrderStatus
    {
#region constructor
        public OrderStatus() 
        {
        }
#endregion
#region fields
        public int orderstatusid;
        public string statuscode;
        public string description;
#endregion
#region propertiies
        public int OrderStatusID 
        {
            get { return orderstatusid; }
            set { orderstatusid = value; }
        }
        public string StatusCode 
        {
            get { return statuscode; }
            set { statuscode = value; }
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