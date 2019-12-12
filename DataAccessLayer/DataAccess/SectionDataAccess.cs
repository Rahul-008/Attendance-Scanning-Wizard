using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;
using DataLayer.Models.UserModels;

namespace DataAccessLayer
{
    public class SectionDataAccess : BaseDataAccess<SectionModel>
    {
        public override string TableName => "Sections";

        public override SectionModel Create(SectionModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Sections (SectionName, FacultyId, CreatedAt) 
                                   VALUES(@SectionName, @FacultyId, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override SectionModel Update(SectionModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Sections SET SectionName = @SectionName WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }

        public List<SectionModel> GetByFaculty(FacultyUserModel faculty)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = $"SELECT * FROM Sections WHERE FacultyId = @Id";
                return conn.Query<SectionModel>(query, faculty).ToList();
            }
        }
    }
}
