using System.Configuration;
using System.Data.SQLite;

namespace DataAccessLayer.DBConnections
{
    internal static class SQLiteDBConnection
    {
        public static SQLiteConnection Get()
        {
            return new SQLiteConnection(ConnectionString);
        }

        private static string ConnectionString
        {
            get => ConfigurationManager.ConnectionStrings["SQLite"].ConnectionString;
        }
    }
}
