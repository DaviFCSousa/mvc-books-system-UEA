using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using LibraryManager.Models.Contracts.Repositories;

namespace LibraryManager.Models.Contexts
{
    public class ConnectionManager : IConnectionManager
    {

        //biblioteca

        private static string _connectionName = "biblioteca";
        private static SqlConnection connection = null;

        public ConnectionManager(IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString(_connectionName);
            if (connection == null)
                connection = new SqlConnection(connStr);


        }


        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
