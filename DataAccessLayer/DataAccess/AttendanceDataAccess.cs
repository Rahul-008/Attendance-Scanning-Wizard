using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;

namespace DataAccessLayer
{
    public class AttendanceDataAccess : BaseDataAccess<AttendanceModel>
    {
        public override string TableName => "Attendances";

        public override AttendanceModel Create(AttendanceModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"INSERT INTO Attendances (StudentId, ClassId, Entry, ScanTime, CreatedAt) VALUES(@StudentId, 
                                @ClassId, @Entry, @ScanTime, @CreatedAt);
                             SELECT last_insert_rowid();";
                var newId = conn.ExecuteScalar<int>(query, model);
                model.Id = newId;
            }

            return model;
        }

        public override AttendanceModel Update(AttendanceModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Attendances SET Date = @Date, StartTime = @StartTime, EndTime = EndTime,
                                RoomNo = @RoomNo WHERE Id = @Id";
                conn.Execute(query, model);
            }

            return model;
        }

        public List<AttendanceModel> GetAllBySection (int SectionId)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Attendances where ClassId in
                                (SELECT Id from Classes where SectionId  = @SectionId);";
                var parameters = new DynamicParameters();
                parameters.Add("@SectionId", SectionId);
                return conn.Query<AttendanceModel>(query, parameters).ToList();
            }
        }

        public void DeleteAllByClass (int ClassId)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"DELETE FROM Attendances where ClassId = @ClassId;";
                var parameters = new DynamicParameters();
                parameters.Add("@ClassId", ClassId);
                conn.Execute(query, parameters);
            }
        }

        public void DeleteAllByStudentInSection(int StudentId, int SectionId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"DELETE from Attendances where StudentId = @StudentId AND ClassId in 
                                (SELECT ClassId from Classes where SectionId = @SectionId);";
                var parameters = new DynamicParameters();
                parameters.Add("@StudentId", StudentId);
                parameters.Add("@SectionId", SectionId);
                conn.Execute(query, parameters);
            }
        }

        public void UpdateManualByStudentIdAndClassIdAndEntry(int StudentId, int ClassId, int Entry)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Attendances SET entry = @Entry where StudentId = @StudentId and ClassId = @ClassId;";
                var parameters = new DynamicParameters();
                parameters.Add("@StudentId", StudentId);
                parameters.Add("@ClassId", ClassId);
                parameters.Add("@Entry", Entry);
                conn.Execute(query, parameters);
            }
        }
    }
}
