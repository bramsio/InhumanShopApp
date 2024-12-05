using System;
using System.Collections.Generic;
using System.ComponentModel;
using static InhumanShopApp.Infrastructure.Constants.ValidationConstants;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhumanShopApp.Infrastructure.Data.Models
{
    public class ProfileViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = requireNameMessage)]
        public string Name { get; set; }

        [Required(ErrorMessage = requireEmailMessage)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(passwordMaxLength, MinimumLength = passwordMinLength, ErrorMessage = passwordLengthErrorMessage)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; } 
    }

}
