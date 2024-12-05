using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static InhumanShopApp.Infrastructure.Constants.ValidationConstants;
using System.Text;
using System.Threading.Tasks;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = requireEmailMessage)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = requirePasswordMessage)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
