﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter Your Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
