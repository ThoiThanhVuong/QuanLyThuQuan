using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using QuanLyThuQuan.Services;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuQuan.BUS
{
    internal class TempDataReservationBUS : BaseBUS<TempDataReservationModel, int>
    {
        private TempDataReservationDAO TDAO = new TempDataReservationDAO();
        private static readonly TempDataReservationBUS Instance = new TempDataReservationBUS();
        // Prevent new TempDataReservationBUS
        public TempDataReservationBUS() { }

        // Getter
        public static TempDataReservationBUS GetInstance()
        {
            return Instance;
        }

        public override List<TempDataReservationModel> GetAll()
        {
            //return new reservationItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).GetAll();
            return new TempDataReservationDAO().GetAll().ToList();
        }

        public TempDataReservationModel GetByID(string id, string condition)
        {
            TempDataReservationModel reservation = new TempDataReservationDAO().GetByID(id, condition);
            if (reservation == null)
                return null;
            return new TempDataReservationModel(reservation.reservationID, reservation.memberID, reservation.startTime, reservation.endTime, reservation.status);
        }

        public List<TempDataReservationModel> FilterByProduct(ReservationStatus status)
        {
            return new TempDataReservationDAO().GetByStatus(status).ToList();
        }

        public void Add(TempDataReservationModel transaction)
        {
            //new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Insert(transaction);
            TDAO.Insert(transaction);
        }

        public void Update(TempDataReservationModel transaction)
        {
            //new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Update(transaction);
            TDAO.Update(transaction);
        }

        public void Delete(string id)
        {
            //new TransactionDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Delete(id);
            TDAO.Delete(id);
        }

        //!change 
        public void RevertToTransaction()
        {
            ConvertToTransaction.getInstance().ConvertReservationToTransaction(null);
            ConvertToTransaction.getInstance().ConvertReservationItemsToTransactionItems(null);
        }
    }
}
