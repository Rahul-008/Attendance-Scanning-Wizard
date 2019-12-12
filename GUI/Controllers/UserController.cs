using DataAccessLayer;
using DataLayer.Models;
using DataLayer.Models.BaseModels;
using DataLayer.Models.UserModels;
using System.Collections.Generic;

namespace GUI.Controllers
{
    internal class UserController : BaseController<BaseUserModel, UserDataAccess>
    {
        protected override UserDataAccess DataAccess => new UserDataAccess();

        public FacultyUserModel GetByEmail(string email)
        {
            return DataAccess.GetByEmail(email);
        }

        public StudentUserModel GetByAcademicId(string AcademicId)
        {
            return DataAccess.GetByAcademicId(AcademicId);
        }
    }
}
