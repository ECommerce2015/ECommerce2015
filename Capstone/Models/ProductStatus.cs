using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class ProductStatus
    {
#region constructor
        public ProductStatus() {
        }
#endregion
#region fields
        public int productstatusid;
        public DateTime statusDate;
        public string description;
#endregion
#region properties
        public int ProductStatusID 
        {
            get { return productstatusid; }
            set { productstatusid = value; }
        }
        public DateTime StatusDate 
        {
            get { return statusDate; }
            set { statusDate = value; }
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