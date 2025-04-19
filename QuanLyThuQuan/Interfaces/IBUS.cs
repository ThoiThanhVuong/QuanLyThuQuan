using System.Collections.Generic;

namespace QuanLyThuQuan.Interfaces
{
    public interface IBUS<T, K>
    {
        List<T> GetAll();
        List<T> GetAllLocal();
        void LoadLocal();
        bool isLocalEmpty();
    }
}
