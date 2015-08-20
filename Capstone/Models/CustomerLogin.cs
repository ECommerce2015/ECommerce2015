//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capstone.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Security.Cryptography;
    using System.Web.Security;
    using System.ComponentModel.DataAnnotations;
    
    public partial class CustomerLogin
    {
        public CustomerLogin() { }

        public int customerLogin_ID { get; set; }
        public int customer_ID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string password { get; set; }
        [Required]
        public System.DateTime dateCreated { get; set; }
        
        public static CustomerLogin ConvertToProperty(DataRow dr)
        {
            CustomerLogin _customerLogin = new CustomerLogin();
            _customerLogin.customerLogin_ID = Convert.ToInt32(dr["customerLogin_ID"]);
            _customerLogin.customer_ID = Convert.ToInt32(dr["customer_ID"]);
            _customerLogin.email = dr["email"].ToString();
            _customerLogin.password = dr["password"].ToString();
            return _customerLogin;
        }
    }
}
