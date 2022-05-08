namespace ETL
{
    public class AppSettings
    {
        public MariaDBSettings {get; set;}
    }
    public class MariaDBSettings
    {
        Server = "YOUR-SERVER.mysql.database.azure.com",
                    Database = "YOUR-DATABASE",
                    UserID = "USER@YOUR-SERVER",
                    Password = "PASSWORD",
                    SslMode = MySqlSslMode.Required,
    }
}
