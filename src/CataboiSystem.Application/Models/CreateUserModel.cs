using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CataboiSystem.Application.Models
{
    public class CreateUserModel
    {
        [Required(ErrorMessage = "User Name é obrigatório!")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "IsAdmin é obrigatório!")]
        public bool IsAdmin { get; set; } = false;

        [EmailAddress]
        [Required(ErrorMessage = "Email é obrigatório!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password é obrigatório!")]
        public string? Password { get; set; }
    }
}