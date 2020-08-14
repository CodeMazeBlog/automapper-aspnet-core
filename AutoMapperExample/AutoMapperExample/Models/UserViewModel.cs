using System;
using System.ComponentModel.DataAnnotations;

namespace AutoMapperExample.Models
{
    public class UserViewModel
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "BMI")]
        public double Bmi { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Secondary Address")]
        public bool HasSecondaryAddress { get; set; }
    }
}
