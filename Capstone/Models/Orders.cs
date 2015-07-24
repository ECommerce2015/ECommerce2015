using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class Orders
    {
#region constructor
        public Orders() { 
                    
        }
#endregion
#region fields
        public int ordersid;
        public List<Int16> customerid;
        public List<Int16> shippingaddressid;
        public List<Int16> customerbillingid;
        public List<Int16> orderdetailsid;
        public List<Int16> orderstatusid;
        public List<Int16> shippingmethodid;
        public DateTime orderdate;
        public float tax;
        public float grandtotal;
#endregion
#region properties
        public int OrderID 
        {
            get { return ordersid; }
            set { OrderID = value; }
        }
        public List<Int16> CustomerID 
        {
            get { return customerid; }
            set { customerid = value; }
        }
        public List<Int16> ShippingAddressID 
        {
            get { return shippingaddressid; }
            set { shippingaddressid = value;  }
        }
        public List<Int16> CustomerBillingID 
        {
            get { return customerbillingid; }
            set { customerbillingid = value; }
        }
        public List<Int16> OrderDetailID 
        {
            get { return orderdetailsid; }
            set { orderdetailsid = value; }
        }
        public List<Int16> OrderStatusID 
        {
            get { return orderstatusid; }
            set { orderstatusid = value; }
        }
        public List<Int16> ShippingMethodID 
        {
            get { return shippingmethodid; }
            set { shippingmethodid = value; }
        }
        public DateTime OrderDate 
        {
            get { return orderdate; }
            set { orderdate = value; }
        }
        public float Tax 
        {
            get { return tax; }
            set { tax = value; }
        }
        public float GrandTotal 
        {
            get { return grandtotal; }
            set { grandtotal = value; }
        }
#endregion
#region methods
#endregion
    }
}