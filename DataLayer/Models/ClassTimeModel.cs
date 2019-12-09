using DataLayer.Models.BaseModels;
using System;

namespace DataLayer.Models
{
    public class ClassTimeModel : BaseModel
    {
        public string ClassTimeText { get; set; }

        public override void IsValid()
        {
            throw new NotImplementedException();
        }

    }
}