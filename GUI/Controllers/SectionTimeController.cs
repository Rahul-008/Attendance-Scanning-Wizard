using DataAccessLayer;
using DataLayer.Models;
using System.Collections.Generic;

namespace GUI.Controllers
{
    internal class SectionTimeController : BaseController<SectionTimeModel, SectionTimeDataAccess>
    {
        protected override SectionTimeDataAccess DataAccess => new SectionTimeDataAccess();

        public List<SectionTimeModel> GetBySection(SectionModel section)
        {
            return DataAccess.GetBySection(section);
        }

        public void RemoveAllBySection(int SectionId)
        {
            DataAccess.RemoveAllBySection(SectionId);
        }

        public List<SectionTimeModel> GetByFaculty(int FacultyId)
        {
            return DataAccess.GetByFaculty(FacultyId);
        }
    }
}
