using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InhumanShopApp.Infrastructure.Constants.ValidationConstants;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = requireEmailMessage)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
