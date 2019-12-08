using DataLayer.Models.BaseModels;
using System;

namespace DataLayer.Models
{
    public class WeekDayModel : BaseModel
    {
        public string WeekDayText { set; get; }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return WeekDayText;
        }
    }
}
