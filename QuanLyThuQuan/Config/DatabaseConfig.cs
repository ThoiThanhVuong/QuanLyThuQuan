namespace QuanLyThuQuan.Config
{
    class DatabaseConfig
    {
        private readonly string server = "localhost";
        private readonly string databaseName = "quanlythuquan";
        private readonly string userID = "root";
        private readonly string password = "";
        private static readonly DatabaseConfig _Instance = new DatabaseConfig();

        private DatabaseConfig() { }
        public static DatabaseConfig GetInStance() { return _Instance; }
        public string GetServer() { return this.server; }
        public string GetDatabaseName() { return this.databaseName; }
        public string GetUserID() { return this.userID; }
        public string GetPassword() { return this.password; }
    }
}