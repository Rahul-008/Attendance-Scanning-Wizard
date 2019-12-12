using DataAccessLayer.Interfaces;
using DataLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GUI.Controllers
{
    internal abstract class BaseController<TModel, TDataAccess>
        where TDataAccess : IBaseDataAccess<TModel>
        where TModel : IModel
    {
        protected abstract TDataAccess DataAccess { get; }

        public List<TModel> Get()
        {
            return DataAccess.Get().ToList();
        }

        public TModel Get(int id)
        {
            return DataAccess.Get(id);
        }

        public TModel Create(TModel model)
        {
            return DataAccess.Create(model);
        }

        public TModel Update(TModel model)
        {
            return DataAccess.Update(model);
        }

        public void Delete(TModel model)
        {
            DataAccess.Delete(model.Id);
        }
    }
}
