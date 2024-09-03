using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IBookingService : IGenericService<Booking>
    {
        List<Booking> TGetApprovedBookings();
        List<Booking> TGetCancelledBookings();
        List<Booking> TGetWaitedBookings();
        void TBookingStatusChangeApproved(int id);
        void TBookingStatusChangeCancel(int id);
        void TBookingStatusChangeWait(int id);
        int TGetBookingCount();
    }
}
