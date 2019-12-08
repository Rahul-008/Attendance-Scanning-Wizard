using DataLayer.Utils;

namespace DataLayer.Interfaces
{
    public interface IUser : IModel
    {
        string AcademicId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string FullName { get; }
        UserTypes UserType { get; }
    }
}
