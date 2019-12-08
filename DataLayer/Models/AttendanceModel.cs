using DataLayer.Models.BaseModels;
using System;

namespace DataLayer.Models
{
    public class AttendanceModel : BaseModel
    {
        public int Entry { set; get; }
        public DateTime ScanTime { set; get; }
        public int ClassId { set; get; }
        public int StudentId { set; get; }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
