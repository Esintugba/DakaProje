using Mekel.BusinessLayer.Abstract;
using Mekel.DataAccessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.BusinessLayer.Concrate
{
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public void TDelete(Reservation t)
        {
           _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public int TGetReservationCount()
        {
            return _reservationDal.GetReservationCount();
        }

        public void TInsert(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public List<Reservation> TLast6Reservations()
        {
            return _reservationDal.Last6Rezervations();
        }

        public void TReservationStatusChangeApproved(Reservation reservation)
        {
            _reservationDal.ReservationStatusChangeApproved(reservation);
        }

        public void TReservationStatusChangeApproved2(int id)
        {
            _reservationDal.ReservationStatusChangeApproved2(id);
        }

        public void TReservationStatusChangeApproved3(int id)
        {
            _reservationDal.ReservationStatusChangeApproved3(id);
        }

        public void TReservationStatusChangeCancel(int id)
        {
            _reservationDal.ReservationStatusChangeCancel(id);
        }

        public void TReservationStatusChangeWait(int id)
        {
            _reservationDal.ReservationStatusChangeWait(id);
        }

        public void TUpdate(Reservation t)
        {
           _reservationDal.Update(t);
        }
    }
}
