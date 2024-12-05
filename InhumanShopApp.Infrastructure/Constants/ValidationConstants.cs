using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhumanShopApp.Infrastructure.Constants
{
    public class ValidationConstants
    {
        public const string requireEmailMessage = "Email is required.";
        public const string requirePasswordMessage = "Password is required.";
        public const string passwordLengthErrorMessage = "The {0} must be at {2} and at max {1} characters long.";
        public const string requireConfirmPasswordMessage = "Confirm Password is required.";
        public const string notMatchingPasswordsErrorMessage = "Password does not match.";
        public const string requireNameMessage = "Name is required.";

        public const int passwordMaxLength = 40;
        public const int passwordMinLength = 8;
    }
}
