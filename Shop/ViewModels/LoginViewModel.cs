using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter Your e-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
