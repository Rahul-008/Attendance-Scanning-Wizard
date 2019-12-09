using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IBaseDataAccess<TModel>
    {
        IEnumerable<TModel> Get();

        TModel Get(int id);

        TModel Create(TModel model);

        TModel Update(TModel model);

        void Delete(int id);
    }
}
