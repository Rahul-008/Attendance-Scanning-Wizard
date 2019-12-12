using DataAccessLayer.DataAccess;
using DataLayer.Models;

namespace GUI.Controllers
{
    internal class ClassTimeController : BaseController<ClassTimeModel, ClassTimeDataAccess>
    {
        protected override ClassTimeDataAccess DataAccess => new ClassTimeDataAccess();
    }
}
