using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLayer
{
    public class SectionTimeDataAccess : BaseDataAccess<SectionTimeModel>
    {
        public override string TableName => "SectionTimes";

        public override SectionTimeModel Create(SectionTimeModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO SectionTimes (StartTimeId, EndTimeId, WeekDayId, ClassType, RoomNo, 
                                SectionId, CreatedAt) VALUES(@StartTimeId, @EndTimeId, @WeekDayId, @ClassType,
                                    @RoomNo, @SectionId, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override SectionTimeModel Update(SectionTimeModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE SectionTimes SET StartTimeId = @StartTimeId, EndTimeId = @EndTimeId, 
                                WeekDayId = @WeekDayId, ClassType = @ClassType, RoomNo = @RoomNo WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }

        public List<SectionTimeModel> GetBySection(SectionModel section)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = $"SELECT * FROM SectionTimes WHERE SectionId = @Id";
                return conn.Query<SectionTimeModel>(query, section).ToList();
            }
        }

        public void RemoveAllBySection(int SectionId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = $"DELETE FROM SectionTimes WHERE SectionId = @SectionId"; 
                var parameters = new DynamicParameters();
                parameters.Add("@SectionID", SectionId);
                conn.ExecuteScalar<int>(query, parameters);
            }
        }

        public List<SectionTimeModel> GetByFaculty(int FacultyId)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM SectionTimes where SectionId in
                                (SELECT Id FROM Sections WHERE FacultyId = @FacultyId)";
                var parameters = new DynamicParameters();
                parameters.Add("@Facultyid", FacultyId);
                return conn.Query<SectionTimeModel>(query, parameters).ToList();
            }
        }
    }
}
