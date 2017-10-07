using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lap_4_5_6.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255,ErrorMessage ="The {0} must be at 255")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="!!!")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}