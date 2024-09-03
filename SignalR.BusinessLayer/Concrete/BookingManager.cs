using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TAdd(Booking entity)
        {
            _bookingDal.Add(entity);
        }

        public void TBookingStatusChangeApproved(int id)
        {
            _bookingDal.BookingStatusChangeApproved(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
           _bookingDal.BookingStatusChangeWait(id);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public List<Booking> TGetApprovedBookings()
        {
            return _bookingDal.GetListByFilter(b => b.Status == "Rezervasyon onaylandı");
        }

        public int TGetBookingCount()
        {
            return _bookingDal.GetBookingCount();
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetCancelledBookings()
        {
            return _bookingDal.GetListByFilter(b => b.Status == "Rezervasyon iptal Edildi");
        }

        public List<Booking> TGetListAll()
        {
            return _bookingDal.GetListAll();
        }

        public List<Booking> TGetListByFilter(Expression<Func<Booking, bool>> where)
        {
            return _bookingDal.GetListByFilter(where);
        }

        public List<Booking> TGetWaitedBookings()
        {
            return _bookingDal.GetListByFilter(b => b.Status == "Rezervasyon bekletiliyor");
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }
    }
}
