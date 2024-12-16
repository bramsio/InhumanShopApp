using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhumanShopApp.Infrastructure.Constants
{
    public static class ErrorMessages
    {
        public const string requireFieldMessage = "The field {0} is required.";
        public const string stringLengthErrorMessage = "The {0} must be at {2} and at max {1} characters long.";
        public const string notMatchingPasswordsErrorMessage = "Password does not match.";
        public const string invalidEmailMessage = "Invalid email format.";
        public const string invalidPhoneMessage = "Invalid phone number format.";
    }

    public static class UserConstants
    {
        public const int userNameMaxLength = 50;
        public const int userNameMinLength = 5;

        public const int passwordMaxLength = 40;
        public const int passwordMinLength = 8;
    }
    public static class ProductConstants
    {
        public const int productNameMaxLength = 50;
        public const int productNameMinLength = 5;

        public const int productDescriptionMaxLength = 1500;
        public const int productDescriptionMinLength = 30;
    }
    public static class CategoryConstants
    {
        public const int categoryNameMaxLength = 30;
        public const int categoryNameMinLength = 3;
    }
    public static class ChatConstants
    {
        public const int messageContentMaxLenght = 1000;
        public const int messageContentMinLength = 10;
    }
    public static class OrderConstants
    {
        public const int statusMaxLength = 50;
        public const int statusMinLength = 3;
    }
    public static class RoleConstants
    {
        public const int roleNameMaxLength = 20;
        public const int roleNameMinLength = 3;
    }
    public static class StatusConstants
    {
        public const int statusNameMaxLength = 30;
        public const int statusNameMinLength = 3;
    }
    public static class VeterinarianConstants
    {
        public const int veterinarianNameMaxLength = 50;
        public const int veterinarianNameMinLength = 5;

        public const int veterinarianSpecializationMaxLength = 50;
        public const int veterinarianSpecializationMinLength = 4;

        public const string invalidVeterinarianMessage = "Invalid phone number format.";
    }
    public static class SizeConstants
    {
        public const int sizeNameMaxLength = 30;
        public const int sizeNameMinLength = 3;
    }
}
