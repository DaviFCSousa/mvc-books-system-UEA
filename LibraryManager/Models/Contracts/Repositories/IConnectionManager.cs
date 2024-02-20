using NuGet.Protocol.Plugins;
using System.Data.SqlClient;

namespace LibraryManager.Models.Contracts.Repositories
{
    public interface IConnectionManager
    {
       SqlConnection GetConnection();
    }
}
