using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.AboutDtos;

namespace SignalRWebUI.Controllers
{
    public class DefaultAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7177/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<List<ResultAboutDto>>(readData);
                return View(jsonData);
            }
            return View();
        }
    }
}
