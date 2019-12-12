using DataAccessLayer.DataAccess;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Controllers
{
    internal class WeekDayController : BaseController<WeekDayModel, WeekDayDataAccess>
    {
        protected override WeekDayDataAccess DataAccess => new WeekDayDataAccess();
    }
}
