using System;
using DataLayer.Models;

namespace DataAccessLayer.DataAccess
{
    public class ClassTimeDataAccess : BaseDataAccess<ClassTimeModel>
    {
        public override string TableName { get; } = "ClassTimes";

        public override ClassTimeModel Create(ClassTimeModel model)
        {
            throw new NotImplementedException();
        }

        public override ClassTimeModel Update(ClassTimeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
