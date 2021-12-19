using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCore_19_12_2021.Model
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]

        public string Password { get; set; }
    }
}
