using DataAccessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    internal class AttendanceController : BaseController<AttendanceModel, AttendanceDataAccess>
    {
        protected override AttendanceDataAccess DataAccess => new AttendanceDataAccess();

        public List<AttendanceModel> GetAllBySection (int SectionId)
        {
            return DataAccess.GetAllBySection(SectionId);
        }

        public void DeleteAllByClass(int ClassId)
        {
            DataAccess.DeleteAllByClass(ClassId);
        }

        public void DeleteAllByStudentInSection(int StudentId, int SectionId)
        {
            DataAccess.DeleteAllByStudentInSection(StudentId, SectionId);
        }

        public void UpdateManualByStudentIdAndClassIdAndEntry(int StudentId, int ClassId, int Entry)
        {
            DataAccess.UpdateManualByStudentIdAndClassIdAndEntry(StudentId, ClassId, Entry);
        }
    }
}
