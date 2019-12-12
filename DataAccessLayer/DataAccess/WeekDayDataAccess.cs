using System;
using DataLayer.Models;

namespace DataAccessLayer.DataAccess
{
    public class WeekDayDataAccess : BaseDataAccess<WeekDayModel>
    {
        public override string TableName { get; } = "WeekDays";

        public override WeekDayModel Create(WeekDayModel model)
        {
            throw new NotImplementedException();
        }

        public override WeekDayModel Update(WeekDayModel model)
        {
            throw new NotImplementedException();
        }
    }
}
