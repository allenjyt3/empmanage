using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpManagement.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required(ErrorMessage ="The name field is required")]
        public string name { get; set; }
        [Required(ErrorMessage = "The email field is required")]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public int phone { get; set; }
    }
}