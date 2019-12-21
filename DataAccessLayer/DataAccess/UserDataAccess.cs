using Dapper;
using DataAccessLayer.DBConnections;
using DataLayer.Models;
using DataLayer.Models.BaseModels;
using DataLayer.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class UserDataAccess : BaseDataAccess<BaseUserModel>
    {
        public override string TableName { get; } = "Users";

        //public override List<BaseUserModel> Get()
        //{
        //    using (IDbConnection conn = SQLiteDBConnection.Get())
        //    {
        //        return conn.Query<dynamic, FacultyUserModel, StudentUserModel, BaseUserModel>
        //        ($"SELECT * FROM {TableName}", (baseUser, faculty, student) =>
        //        {
        //            if (baseUser.UserType == UserTypes.Faculty)
        //            {
        //                return new FacultyUserModel();
        //            }
        //            else if (baseUser.UserType == UserTypes.Student)
        //            {
        //                return new StudentUserModel();
        //            }
        //            return baseUser;
        //        });
        //    }
        //}

        public FacultyUserModel ValidateLogin(string email, string password)
        {
            FacultyUserModel faculty = null;
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users where Email = @email AND Password = @password;";
                var parameters = new DynamicParameters();
                parameters.Add("@email", email);
                parameters.Add("@password", password);
                try
                {
                    faculty = conn.QuerySingle<FacultyUserModel>(query, parameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Login info. Please try again");
                }
             }
            return faculty;
        }

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

        public FacultyUserModel UpdateInfo(FacultyUserModel model)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE Id = @Id";
                conn.Execute(query, model);
            }
            return model;
        }

        public bool IsValidUser()
        {
            throw new NotImplementedException();
        }

        public override BaseUserModel Update(BaseUserModel model)
        {
            throw new NotImplementedException();
        }

        public FacultyUserModel GetPasswordByUser(FacultyUserModel model)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT Password FROM Users where Id = @Id;";
                var parameters = new DynamicParameters();
                parameters.Add("@Id", model.Id);
                return conn.QuerySingle<FacultyUserModel>(query, parameters);
            }
        }

        public FacultyUserModel GetByEmail(string email)
        {
            FacultyUserModel faculty = null;
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users WHERE Email = @Email;";
                var parameters = new DynamicParameters();
                parameters.Add("@Email", email);
                try
                {
                    faculty = conn.QuerySingle<FacultyUserModel>(query, parameters);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Incorrect email or password. Please try again");
                }
                return faculty;
            }
        }

        public void UpdatePasswordByUser(int Id, string Password, string salt)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"UPDATE Users SET Password = @Password, Salt = @Salt WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("@Id", Id);
                parameters.Add("@Password", Password);
                parameters.Add("@Salt", salt);
                conn.Execute(query, parameters);
            }
        }

        public List<StudentUserModel> GetBySection (SectionModel section)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users where Id in (SELECT StudentId FROM SectionStudents where SectionId = @Id);";
                return conn.Query<StudentUserModel>(query, section).ToList();
            }
        }

        public int GetIdByAcademicId(string AcademicId)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT Id FROM Users where AcademicId = @AcademicId;";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AcademicId", AcademicId);
                return conn.QuerySingle<int>(query, parameters);
            }
        }

        public StudentUserModel GetByAcademicId(string AcademicId)
        {
            using(IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users where AcademicId = @AcademicId;";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@AcademicId", AcademicId);
                return conn.QuerySingle<StudentUserModel>(query, parameters);
            }
        }

        public List<StudentUserModel> SearchByAcademidIdAndSectionId(string key, int sectionId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users where AcademicId like ('%' || @key || '%') AND UserType = 1 AND id in
                                (select StudentId FROM SectionStudents where SectionId = @SectionId)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@key", key);
                parameters.Add("@SectionId", sectionId);
                return conn.Query<StudentUserModel>(query, parameters).ToList();
            }
        }

        public List<StudentUserModel> SearchByNameAndSectionId(string key, int SectionId)
        {
            using (IDbConnection conn = SQLiteDBConnection.Get())
            {
                var query = @"SELECT * FROM Users where (FirstName like ('%' || @key || '%') OR LastName like ('%' || @key || '%')) AND UserType = 1 AND id in
                                (select StudentId FROM SectionStudents where SectionId = @SectionId);";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@key", key);
                parameters.Add("@SectionId", SectionId);
                return conn.Query<StudentUserModel>(query, parameters).ToList();
            }
        }
    }
}
