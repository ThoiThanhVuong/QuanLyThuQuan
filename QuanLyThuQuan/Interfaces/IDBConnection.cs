using MySql.Data.MySqlClient;

namespace QuanLyThuQuan.Interfaces
{
    public interface IDBConnection
    {
        MySqlConnection GetConnection();
        void Close();
    }
}
