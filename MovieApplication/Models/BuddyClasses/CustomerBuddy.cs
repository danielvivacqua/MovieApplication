using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApplication.Models
{

    [MetadataType(typeof(CustomerBuddy))]
    public partial class Customer
    {
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
            set { }
        }
    }
    sealed class CustomerBuddy
    {
        
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        
        [Display(Name ="Last Name")]
       // [Required]
        public string LastName { get; set; }

        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
    }
}