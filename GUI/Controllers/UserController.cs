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

        public FacultyUserModel ValidateLogin(string email, string password)
        {
            return DataAccess.ValidateLogin(email, password);
        }

        public FacultyUserModel Update(FacultyUserModel model)
        {
            return DataAccess.UpdateInfo(model);
        }

        public bool IsValidUser(string email, string pass)
        {
            return DataAccess.IsValidUser();
        }

        public FacultyUserModel GetPasswordByUser (FacultyUserModel model)
        {
            return DataAccess.GetPasswordByUser(model);
        }

        public void UpdatePasswordByUser(int Id, string password, string salt)
        {
            DataAccess.UpdatePasswordByUser(Id, password, salt);
        }

        public List<StudentUserModel> GetBySection(SectionModel section)
        {
            return DataAccess.GetBySection(section);
        }

        public int GetIdByAcademicId(string AcademicId)
        {
            return DataAccess.GetIdByAcademicId(AcademicId);
        }

        public StudentUserModel GetByAcademicId(string AcademicId)
        {
            return DataAccess.GetByAcademicId(AcademicId);
        }

        public List<StudentUserModel> SearchByNameAndSectionId(string key, int SectionId)
        {
            return DataAccess.SearchByNameAndSectionId(key, SectionId);
        }

        public List<StudentUserModel> SearchByAcademidIdAndSectionId(string key, int SectionId)
        {
            return DataAccess.SearchByAcademidIdAndSectionId(key, SectionId);
        }

        public FacultyUserModel GetByEmail(string email)
        {
            return DataAccess.GetByEmail(email);
        }
    }
}
