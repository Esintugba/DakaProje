using Mekel.WebUI.Dtos.ReservationDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Mekel.WebUI.Controllers
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {
       
        private readonly IHttpClientFactory _httpClientFactory;
        public ReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Reservation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reservation(CreateReservationDto createReservationDto)
        {
         

                createReservationDto.Durum = "Onay Bekliyor";
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(createReservationDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                await client.PostAsync("http://localhost:5237/api/Reservation", stringContent);

                return RedirectToAction("Index", "Home");
         
            
        }
    }
}
