﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlysBookStore_UI.Models
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress]

        //public String UserName { get; set; }
        public String EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Your password is must be {2} to {1} characters", MinimumLength = 6)]
        public string Password { get; set; }



        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }





    }

    public class LoginModel
    {

    }
}
