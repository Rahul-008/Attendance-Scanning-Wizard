using System;
using System.Linq;
using System.Text.RegularExpressions;
using DataLayer.Models.BaseModels;
using DataLayer.Utils;


namespace DataLayer.Models.UserModels
{
    public class FacultyUserModel : BaseUserModel
    {
        public override UserTypes UserType => UserTypes.Faculty;

        public override void IsValid()
        {

            if (!Email.EndsWith("@aiub.edu"))
            {
                throw new Exception("Invaild Email.You need an email address with aiub.edu domain");
            }

            var FacultyIdFormat = new Regex("\\d{4}-\\d{4}-[1-3]$");
            if (!FacultyIdFormat.IsMatch(AcademicId))
            {
                throw new Exception("Invaild ID format.Please check your academic ID");
            }

            if (Password.Length < 6)
            {
                throw new Exception("Weak password. Password length should be 6 at least");
            }
            if (!Password.Any(char.IsUpper) || !Password.Any(char.IsLower) || !Password.Any(char.IsDigit))
            {
                throw new Exception("Weak password.please create a password using combintation of uppercase and lowercase letters and numbers");
            }
        }
    }
}
