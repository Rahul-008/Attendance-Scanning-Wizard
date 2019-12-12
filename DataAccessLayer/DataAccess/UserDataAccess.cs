using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;
using DataLayer.Models.BaseModels;
using DataLayer.Models.UserModels;
using System;
using System.Data;
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
                var query = @"INSERT INTO Users (AcademicId, FirstName, LastName, Email, Password, Salt, CreatedAt, UserType) 
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

        public FacultyUserModel GetByEmail(string email)
        {
            FacultyUserModel faculty = null;
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users WHERE Email = @Email;";
                var parameters = new DynamicParameters();
                parameters.Add("@Email", email);
                try
                {
                    faculty = conn.QuerySingle<FacultyUserModel>(query, parameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Incorrect email or password. Please try again");
                }
                return faculty;
            }
        }

        public StudentUserModel GetByAcademicId(string AcademicId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users where AcademicId = @AcademicId;";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AcademicId", AcademicId);
                return conn.QuerySingle<StudentUserModel>(query, parameters);
            }
        }
    }
}
