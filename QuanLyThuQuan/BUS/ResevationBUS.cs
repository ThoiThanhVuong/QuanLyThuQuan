using QuanLyThuQuan.DAO;
using QuanLyThuQuan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuQuan.BUS
{
    class ResevationBUS
    {
        private ReservationDAO reservationDAO = new ReservationDAO();

        public List<ReservationModel> GetAllReservationsWithItems()
        {
            return reservationDAO.GetAllReservationsWithItems();
        }

        public ReservationModel GetReservationByID(int id)
        {
            return reservationDAO.GetReservationByID(id);
        }

        public bool AddReservationWithItems(ReservationModel reservation)
        {
            return reservationDAO.AddReservationWithItems(reservation);
        }

        //public bool UpdateReservationWithItems(ReservationModel reservation)
        //{
        //    return reservationDAO.UpdateReservationWithItems(reservation);
        //}

        //public bool DeleteReservation(int reservationID)
        //{
        //    return reservationDAO.DeleteReservation(reservationID);
        //}

        public int ConfirmReservationAndTransfer(int reservationID)
        {
            return reservationDAO.ConfirmReservationAndTransfer(reservationID);
        }
    }
}
