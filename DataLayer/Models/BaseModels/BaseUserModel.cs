using DataLayer.Interfaces;
using DataLayer.Utils;
using System;
using System.Linq;

namespace DataLayer.Models.BaseModels
{
    abstract public class BaseUserModel : BaseModel
    {
        public abstract UserTypes UserType { get; }
        public string AcademicId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string salt { set; get; }

        public string FullName => $"{FirstName} {LastName}";

        public override void IsValid()
        {
            if (string.IsNullOrWhiteSpace(FullName) || FullName.Any(char.IsDigit))
            {
                throw new Exception("Invalid name. Please Check your name");
            }
        }
    }
}