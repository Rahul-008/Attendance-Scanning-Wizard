using DataAccessLayer.DBConnections;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DataLayer.Interfaces;
using DataAccessLayer.Interfaces;
using System;

namespace DataAccessLayer
{
    public abstract class BaseDataAccess<TModel> : IBaseDataAccess<TModel> where TModel : IModel
    {
        public abstract string TableName { get; }

        public virtual IEnumerable<TModel> Get()
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                return conn.Query<TModel>($"SELECT * FROM {TableName}");
            }
        }

        public virtual TModel Get(int id)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                return conn.QuerySingle<TModel>($@"SELECT * FROM {TableName} 
                                                    WHERE Id = @id", new { Id = id });
            }
        }

        public abstract TModel Create(TModel model);

        public abstract TModel Update(TModel model);

        public void Delete(int id)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                conn.Execute($"DELETE FROM {TableName} WHERE Id = @id", new { Id = id });
            }
        }
    }
}
