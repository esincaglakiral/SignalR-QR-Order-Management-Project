using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BookingDtos;
using System.Text;
using X.PagedList.Extensions;

namespace SignalRWebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7177/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);


				// Sayfalama işlemi
				int pageSize = 5; // Her sayfada gösterilecek kayıt sayısı
				var pagedValues = values.ToPagedList(page, pageSize);
				return View(pagedValues);
				
            }
            return View();
        }


        [HttpGet]
        public IActionResult CreateBooking()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> CreateBooking(CreateBookingDto createBookingDto)
        {
            // Eğer Status alanı modelde var ise, burada 'Onay Bekliyor' olarak ayarlandı
            createBookingDto.Status = "Onay Bekliyor";

            if (ModelState.IsValid) // ModelState kontrolü ekleyin
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createBookingDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var responseMessage = await client.PostAsync("https://localhost:7177/api/Booking", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                // Eğer başarısızsa, model state ve hata mesajı ile birlikte view'ı geri döndür
                ModelState.AddModelError("", "Rezervasyon eklenirken bir hata oluştu.");
            }
            else
            {
                ModelState.AddModelError("", "Model verileri geçersiz.");
            }

            return View(createBookingDto);
        }




        public async Task<IActionResult> DeleteBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7177/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7177/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7177/api/Booking/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }



        public async Task<IActionResult> UpdateApproveReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7177/api/Booking/UpdateBookingApproveById?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7177/api/Booking");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
					// Sayfalama işlemi
					int page = 1;  // İlgili sayfayı belirlemek için
					int pageSize = 5;  // Sayfalama boyutu
					var pagedValues = values.ToPagedList(page, pageSize);

					return View("Index", pagedValues);
					//return View("Index", values);
                }
            }

            return View("Error");
        }



        public async Task<IActionResult> UpdateCancelReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7177/api/Booking/UpdateBookingCancelById?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7177/api/Booking");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);


					// Sayfalama işlemi
					int page = 1;  // İlgili sayfayı belirlemek için
					int pageSize = 5;  // Sayfalama boyutu
					var pagedValues = values.ToPagedList(page, pageSize);

					return View("Index", pagedValues);
					//return View("Index", values);
                }
            }

            return View("Error");
        }



        public async Task<IActionResult> UpdateWaitReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7177/api/Booking/UpdateBookingWaitById?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var updatedResponseMessage = await client.GetAsync("https://localhost:7177/api/Booking");
                if (updatedResponseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await updatedResponseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);


					// Sayfalama işlemi
					int page = 1;  // İlgili sayfayı belirlemek için
					int pageSize = 5;  // Sayfalama boyutu
					var pagedValues = values.ToPagedList(page, pageSize);

					return View("Index", pagedValues);
					//return View("Index", values);
                }
            }

            return View("Error");
        }



        // Onaylı Rezervasyonları Listele
        public async Task<IActionResult> ListApprovedBookings(int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7177/api/Booking/GetApprovedBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);

				// Sayfalama işlemi
				int pageSize = 5;  // Sayfalama boyutu
				var pagedValues = values.ToPagedList(page, pageSize);

				return View("ListApprovedBookings", pagedValues);
				//return View("Index", values);
            }
            return View("ListApprovedBookings", new List<ResultBookingDto>());
        }


        // Bekletilen Rezervasyonları Listele
        public async Task<IActionResult> ListWaitedBookings(int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7177/api/Booking/GetWaitedBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);


				// Sayfalama işlemi
				int pageSize = 5;  // Sayfalama boyutu
				var pagedValues = values.ToPagedList(page, pageSize);

				return View("ListWaitedBookings", pagedValues);
				//return View("Index", values);
            }
            return View("ListWaitedBookings", new List<ResultBookingDto>());
        }

        // İptal Edilen Rezervasyonları Listele
        public async Task<IActionResult> ListCancelledBookings(int page = 1)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7177/api/Booking/GetCancelledBookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);


				// Sayfalama işlemi
				int pageSize = 5;  // Sayfalama boyutu
				var pagedValues = values.ToPagedList(page, pageSize);

				return View("ListCancelledBookings", pagedValues);
				//return View("Index", values);
            }
            return View("ListCancelledBookings", new List<ResultBookingDto>());
        }

    }
}
