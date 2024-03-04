using Mekel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        void ReservationStatusChangeApproved(Reservation reservation);
        void ReservationStatusChangeApproved2(int id);
        int GetReservationCount();
        List<Reservation> Last6Rezervations();
        void ReservationStatusChangeApproved3(int id);
        void ReservationStatusChangeCancel(int id);
        void ReservationStatusChangeWait(int id);
    }
}
