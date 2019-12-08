using DataLayer.Interfaces;
using DataLayer.Models.BaseModels;
using System;
using System.Linq;

namespace DataLayer.Models
{
    public class SectionModel : BaseModel
    {
        public string SectionName { get; set; }
        public int FacultyId { get; set; }

        public override void IsValid()
        {
            if(SectionName == "Course [Section]")
            {
                throw new Exception("Please insert section name");
            }
            if (!SectionName.Contains('[') && !SectionName.Contains(']'))
            {
                throw new Exception("Section name format is invalid. Be sure to use this format: Course [Section]");
            }
        }
    }
}
