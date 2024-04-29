using MySql.Data.MySqlClient;

namespace WF
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection(
            $"server={Config.LocalHost};" +
            $"port={Config.LocalPort};" +
            $"username={Config.LocalUser};" +
            $"password={Config.LocalPassword};" +
            $"database={Config.NameDataBase}"
        );

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnecton()
        {
            return connection;
        }
    }
    
    public static class Config
    {
        public const string LocalHost = "localhost";
        public const string LocalPort = "3306";
        public const string LocalUser = "root";
        public const string LocalPassword = "root";
        public const string NameDataBase = "wfexemple";
    }
}
