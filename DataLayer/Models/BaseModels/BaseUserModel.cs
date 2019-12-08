using DataLayer.Interfaces;
using DataLayer.Utils;
using System;
using System.Linq;

namespace DataLayer.Models.BaseModels
{
    abstract public class BaseUserModel : IUser
    {
        public BaseUserModel(EnumUserTypes userType)
        {
            UserType = userType;
        }

        public EnumUserTypes UserType { get; }
        public int Id { set; get; }
        public string AcademicId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public DateTime createdAt { set; get; }
        public string FullName() => $"{FirstName} {LastName}";
        virtual public void isValid()
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
            {
                throw new Exception("Invalid name. Please Check your names");
            }
            if(!FirstName.All(char.IsLetter) || !LastName.All(char.IsLetter))
            {
                throw new Exception("Invalid name. Please Check your names");
            }
            if (Password.Length < 8)
            {
                throw new Exception("Weak password. Please choose a better password");
            }
            if (!Password.Any(char.IsUpper) || !Password.Any(char.IsLower) || !Password.Any(char.IsDigit))
            {
                throw new Exception("Weak password. Please create a password using combination of uppercase and lowercase letters and numbers");
            }
        }
    }
}
