using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly SignalRContext _context;
        public EfBookingDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public void BookingStatusChangeApproved(int id)
        {
            var value = _context.Bookings.Find(id);
            value.Status = "Rezervasyon onaylandı";

            _context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var value = _context.Bookings.Find(id);
            value.Status = "Rezervasyon iptal Edildi";
            _context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var value = _context.Bookings.Find(id);
            value.Status = "Rezervasyon bekletiliyor";
            _context.SaveChanges();
        }

        public List<Booking> GetApprovedBookings()
        {
            return _context.Bookings.Where(x => x.Status == "Rezervasyon onaylandı").ToList();
        }

        public int GetBookingCount()
        {
            return _context.Bookings.Count();
        }

        public List<Booking> GetCancelledBookings()
        {
            return _context.Bookings.Where(x => x.Status == "Rezervasyon iptal Edildi").ToList();
        }

        public List<Booking> GetWaitedBookings()
        {
            return _context.Bookings.Where(x => x.Status == "Rezervasyon bekletiliyor").ToList();
        }
    }
}
