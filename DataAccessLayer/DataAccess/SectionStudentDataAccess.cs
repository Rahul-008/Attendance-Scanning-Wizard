using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DataAccessLayer.DBConnections;

namespace DataAccessLayer
{
    public class SectionStudentDataAccess
    {
        public string TableName => "SectionsStudents";

        public void Create(int SectionId, int StudentId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO SectionStudents (SectionId, StudentId) 
                                   VALUES(@SectionID, @StudentID);
                             SELECT last_insert_rowid();";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionID", SectionId);
                parameters.Add("@StudentID", StudentId);
                conn.ExecuteScalar<int>(query, parameters);
            }
        }

        public void Remove(int SectionId, int StudentId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"DELETE FROM SectionStudents where SectionId = @SectionId AND StudentId = @StudentId;";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionID", SectionId);
                parameters.Add("@StudentID", StudentId);
                conn.ExecuteScalar<int>(query, parameters);
            }
        }

        public void RemoveAllBySection(int SectionId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"DELETE FROM SectionStudents where SectionId = @SectionId;";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionID", SectionId);
                conn.ExecuteScalar<int>(query, parameters);
            }
        }

        public List<int> GetAllBySection(int SectionId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT StudentId from SectionStudents where SectionId = @SectionId;";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionId", SectionId);
                return conn.Query<int>(query, parameters).ToList();
            }
        }
    }
}
