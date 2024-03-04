using Mekel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        void TReservationStatusChangeApproved(Reservation reservation);
        void TReservationStatusChangeApproved2(int id);
        int TGetReservationCount();
        List<Reservation> TLast6Reservations();
        void TReservationStatusChangeApproved3(int id);
        void TReservationStatusChangeCancel(int id);
        void TReservationStatusChangeWait(int id);
    }
}
