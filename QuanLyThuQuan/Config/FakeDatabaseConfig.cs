namespace QuanLyThuQuan.Config
{
    class FakeDatabaseConfig
    {
        private readonly string server = "";
        private readonly string databaseName = "";
        private readonly string userID = "";
        private readonly string password = "";

        public FakeDatabaseConfig() { }
        public string GetServer() { return this.server; }
        public string GetDatabaseName() { return this.databaseName; }
        public string GetUserID() { return this.userID; }
        public string GetPassword() { return this.password; }
    }
}
