using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()  //manuel mapping
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                Status = createBookingDto.Status,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,
                Description = createBookingDto.Description
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Yapıldı");
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }


        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                BookingID = updateBookingDto.BookingID,
                Name = updateBookingDto.Name,
                Status = updateBookingDto.Status,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Date = updateBookingDto.Date,
                Description = updateBookingDto.Description
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");
        }



        [HttpGet("{id}")]
        public IActionResult GetBookingById(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }


        [HttpGet("GetApprovedBookings")]
        public IActionResult GetApprovedBookings()
        {
            var values = _bookingService.TGetApprovedBookings();
            return Ok(values);
        }


        [HttpGet("GetCancelledBookings")]
        public IActionResult GetCancelledBookings()
        {
            var values = _bookingService.TGetCancelledBookings();
            return Ok(values);
        }

        [HttpGet("GetWaitedBookings")]
        public IActionResult GetWaitedBookings()
        {
            var values = _bookingService.TGetWaitedBookings();
            return Ok(values);
        }



        [HttpGet("UpdateBookingApproveById")]
        public IActionResult UpdateBookingApproveById(int id)
        {
            _bookingService.TBookingStatusChangeApproved(id);
            return Ok();
        }

        [HttpGet("UpdateBookingCancelById")]
        public IActionResult UpdateBookingCancelByID(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok();
        }



        [HttpGet("UpdateBookingWaitById")]
        public IActionResult UpdateBookingWaitByID(int id)
        {
            _bookingService.TBookingStatusChangeWait(id);
            return Ok();
        }
    }
}
