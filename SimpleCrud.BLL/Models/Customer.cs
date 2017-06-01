using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleCrud.BLL.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [RegularExpression(@"(\+[0-9]{2}\s?)?[0-9]{3}\s?[0-9]{3}\s?[0-9]{3}", 
            ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter an address")]
        public string Address { get; set; }
    }
}
