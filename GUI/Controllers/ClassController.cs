using DataAccessLayer;
using DataLayer.Models;
using System.Collections.Generic;

namespace GUI.Controllers
{
    internal class ClassController : BaseController<ClassModel, ClassDataAccess>
    {
        protected override ClassDataAccess DataAccess => new ClassDataAccess();

        public List<ClassModel> GetByFacultyId(int FacultyId)
        {
            return DataAccess.GetByFacultyId(FacultyId);
        }
        public List<ClassModel> GetByDateAndFacultyId(string date, int FacultyId)
        {
            return DataAccess.GetByDateAndFacultyId(date, FacultyId);
        }

        public List<ClassModel> GetBySectionId(int SectionId)
        {
            return DataAccess.GetBySectionId(SectionId);
        }

        public void DeleteAllBySection(int SectionId)
        {
            DataAccess.DeleteAllBySection(SectionId);
        }

        public ClassModel InsertQRCode(int ClassId, string QR)
        {
            return DataAccess.InsertQRCode(ClassId, QR);
        }

        public ClassModel InsertQRDisplayStartTime(int ClassId, string StartTime)
        {
            return DataAccess.InsertQRDisplayStartTime(ClassId, StartTime);
        }

        public ClassModel InsertQRDisplayEndTime(int ClassId, string EndTime)
        {
            return DataAccess.InsertQRDisplayEndTime(ClassId, EndTime);
        }
    }
}
