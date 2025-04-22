using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    internal class TempDataItemReservationBUS : BaseBUS<TempDataItemReservationModel, int>
    {
        private static readonly TempDataItemReservationBUS Instance = new TempDataItemReservationBUS();

        // Prevent new TempDataItemReservationBUS
        public TempDataItemReservationBUS() { }

        // Getter
        public static TempDataItemReservationBUS GetInstance()
        {
            return Instance;
        }

        public override List<TempDataItemReservationModel> GetAll()
        {
            //return new reservationItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).GetAll();
            return new TempDataReservationItemDAO(GetConnectDB()).GetAll();
        }

        public TempDataItemReservationModel GetByID(string id)
        {
            return new TempDataReservationItemDAO(GetConnectDB()).GetByID(id);
        }

        public List<TempDataItemReservationModel> getByReservationID(string id)
        {
            return new TempDataReservationItemDAO(GetConnectDB()).GetByReservationID(id);
        }

        public void Add(TempDataItemReservationModel reservation)
        {
            //new reservationItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Insert(reservation);
            new TempDataReservationItemDAO(GetConnectDB()).Insert(reservation);
        }

        public void AddList(List<TempDataItemReservationModel> reservations)
        {
            new TempDataReservationItemDAO(GetConnectDB()).Insert(reservations);
        }

        public void Update(TempDataItemReservationModel reservation)
        {
            //new reservationItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Update(reservation);
            new TempDataReservationItemDAO(GetConnectDB()).Update(reservation);
        }

        public void UpdateList(List<TempDataItemReservationModel> reservations)
        {
            new TempDataReservationItemDAO(GetConnectDB()).Update(reservations);
        }

        public void Delete(string reservationID, string itemID)
        {
            //new reservationItemDAO(GetIDBConnection(DatabaseConfig.GetInStance())).Delete(id);
            new TempDataReservationItemDAO(GetConnectDB()).Delete(reservationID, itemID);
        }

        public void DeleteList(Dictionary<string, string> KeyReservationIDWithValueItemID)
        {
            new TempDataReservationItemDAO(GetConnectDB()).Delete(KeyReservationIDWithValueItemID);
        }
    }
}
