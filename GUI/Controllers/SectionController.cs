using DataAccessLayer;
using DataLayer.Models;
using DataLayer.Models.UserModels;
using System.Collections.Generic;

namespace GUI.Controllers
{
    internal class SectionController : BaseController<SectionModel, SectionDataAccess>
    {
        protected override SectionDataAccess DataAccess => new SectionDataAccess();

        public List<SectionModel> GetByFaculty(FacultyUserModel faculty)
        {
            return DataAccess.GetByFaculty(faculty);
        }
    }
}
