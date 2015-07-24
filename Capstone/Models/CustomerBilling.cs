using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Models
{
    public class CustomerBilling
    {
#region constructor
        public CustomerBilling() 
        {

        }
#endregion
#region fields
        public List<Int16> customerbillingid;
        public string cardtype;
        public string cardnumber;
        public DateTime expiredate;
#endregion
#region properties
        public List<Int16> CustomerBillingID
        {
            get { return customerbillingid; }
            set { customerbillingid = value; }
        }
        public string CardType
        {
            get { return cardtype; }
            set { cardtype = value; }
        }
        public string CardNumber
        {
            get { return cardnumber; }
            set { cardnumber = value; }
        }
        public DateTime ExpireDate
        {
            get { return expiredate; }
            set { expiredate = value; }
        }
#endregion
#region methods
#endregion
    }
}