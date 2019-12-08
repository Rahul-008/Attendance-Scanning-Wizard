using System;
using System.Text.RegularExpressions;
using DataLayer.Models.BaseModels;
using DataLayer.Utils;

namespace DataLayer.Models
{
    public class StudentUserModel : BaseUserModel
    {
        public override UserTypes UserType => UserTypes.Student;

        public override void IsValid()
        {
            base.IsValid();

            var StudentIdFormat = new Regex("\\d{2}-\\d{5}-\\d{1}");
            if (!StudentIdFormat.IsMatch(AcademicId))
            {
                throw new Exception("Invalid ID format. Please check academic ID");
            }
        }
    }
}
