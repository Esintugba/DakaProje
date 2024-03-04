using Mekel.DataAccessLayer.Abstract;
using Mekel.DataAccessLayer.Concrete;
using Mekel.DataAccessLayer.Repositories;
using Mekel.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.DataAccessLayer.EntityFramework
{
    public class EfReservationDal:GenericRepository<Reservation>, IReservationDal
    {
        public EfReservationDal(Context context) : base(context) 
        {

        }

        public int GetReservationCount()
        {
            var context = new Context();
            var value = context.Reservation.Count();
            return value;
        }

        public List<Reservation> Last6Rezervations()
        {
            var context = new Context();
            var values = context.Reservation.OrderByDescending(x => x.Id).Take(6).ToList();
            return values;
        }

        public void ReservationStatusChangeApproved(Reservation reservation)
        {
            var context = new Context();
            var values = context.Reservation.Where(x => x.Id == reservation.Id).FirstOrDefault();
            values.Durum = "Onaylandı";
            context.SaveChanges();
        }

        public void ReservationStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Reservation.Find(id);
            values.Durum = "Onaylandı";
            context.SaveChanges();
        }

        public void ReservationStatusChangeApproved3(int id)
        {
            var context = new Context();
            var values = context.Reservation.Find(id);
            values.Durum = "Onaylandı";
            context.SaveChanges();
        }

        public void ReservationStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Reservation.Find(id);
            values.Durum = "İptal Edildi";
            context.SaveChanges();
        }

        public void ReservationStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Reservation.Find(id);
            values.Durum = "Müşteri Aranacak";
            context.SaveChanges();
        }
    }
    
}
