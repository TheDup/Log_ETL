using System;
using System.Threading.Tasks;
using MySqlConnector;

namespace Infrastructure
{
    public class MySqlCreate
    {
        static async Task BuildDB()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "YOUR-SERVER.mysql.database.azure.com",
                Database = "YOUR-DATABASE",
                UserID = "USER@YOUR-SERVER",
                Password = "PASSWORD",
                SslMode = MySqlSslMode.Required,
            };

        }
    }
}