using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.Services
{
    internal class ConvertToTransaction
    {
        private static ConvertToTransaction _INSTANCE = new ConvertToTransaction();

        private ConvertToTransaction() { }

        public static ConvertToTransaction getInstance()
        {
            return _INSTANCE;
        }

        // TODO:
        public void ConvertReservationToTransaction(TempDataReservationModel reservation)
        {

        }

        // TODO: 
        public void ConvertReservationItemsToTransactionItems(TempDataItemReservationModel reservationItem)
        {

        }
    }
}
