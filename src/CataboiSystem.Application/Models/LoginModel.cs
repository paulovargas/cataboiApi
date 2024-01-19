using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CataboiSystem.Application.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name é obrigatório!")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password é obrigatório!")]
        public string? Password { get; set; }
    }
}