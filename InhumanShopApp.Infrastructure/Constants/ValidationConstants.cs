using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhumanShopApp.Infrastructure.Constants
{
    public static class ValidationConstants
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
    public static class PostConstants
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 5;

        public const int DescriptionMaxLength = 1500;
        public const int DescriptionMinLength = 30;
    }
}
