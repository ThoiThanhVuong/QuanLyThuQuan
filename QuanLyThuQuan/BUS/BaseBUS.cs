using QuanLyThuQuan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuQuan.BUS
{
    abstract class BaseBUS<T, K> : IBUS<T, K>
    {
        protected readonly List<T> listLocal = new List<T>();

        public abstract List<T> GetAll();

        public List<T> GetAllLocal()
        {
            return new List<T>(listLocal);
        }

        public bool isLocalEmpty()
        {
            return listLocal.Any();
        }

        public void LoadLocal()
        {
            try
            {
                listLocal.Clear();
                listLocal.AddRange(GetAll());
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
