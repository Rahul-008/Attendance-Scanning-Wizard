using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;
using DataLayer.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class UserDataAccess : BaseDataAccess<BaseUserModel>
    {
        public override string TableName => "Users";
        public override BaseUserModel Create(BaseUserModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO {TableName} (AcademicId, FirstName, LastName, Email, Password, Salt, CreatedAt, UserType) 
                                VALUES(@AcademicId, @FirstName, @LastName, @Email, @Password, @Salt, @CreatedAt, @UserType);
                            SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override BaseUserModel Update(BaseUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
