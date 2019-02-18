using System.Data.SqlClient;
using System.Configuration;

namespace Inventory.Configuration
{
    public class MainConn
    {
        private string _connectionString = string.Empty;
        private readonly string _serverName = string.Empty;
        private readonly string _databaseName = string.Empty;
        private readonly string _userId = string.Empty;
        private readonly string _password = string.Empty;

        public MainConn()
        {
            var objConnStringSettings = ConfigurationManager.ConnectionStrings["ApplicationServices"];
            _connectionString = objConnStringSettings.ConnectionString;

            var builder = new SqlConnectionStringBuilder(_connectionString);
            _serverName = builder.DataSource;
            _databaseName = builder.InitialCatalog;
            _userId = builder.UserID;
            _password = builder.Password;
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public string ServerName
        {
            get { return _serverName; }
        }

        public string DatabaseName
        {
            get { return _databaseName; }
        }

        public string UserId
        {
            get { return _userId; }
        }

        public string Password
        {
            get { return _password; }
        }
    }
}