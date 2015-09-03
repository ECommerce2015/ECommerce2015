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
    using System.Security.Cryptography;
    using System.Web.Security;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    
    public partial class Customer
    {
        public int customer_ID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "{0}: 30 is the limit")]
        public string firstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "{0}: 30 is the limit")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",ErrorMessage = "Invalid email")]
        [Remote("CheckEmail", "Registration", ErrorMessage = "Already in use")]
        [StringLength(30, ErrorMessage = "{0}: 30 is the limit")]
        public string email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, ErrorMessage = "{0}: 10 is the limit")]
        public string phone { get; set; }

        
    }
}