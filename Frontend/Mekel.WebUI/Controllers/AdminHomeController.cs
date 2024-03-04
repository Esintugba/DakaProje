using Mekel.WebUI.Dtos.HomeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Mekel.WebUI.Controllers
{
    public class AdminHomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminHomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> AHome()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5237/api/Home");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultHomeDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddHome()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddHome(CreateHomeDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5237/api/Home", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AHome");
            }
            return View();
        }

        public async Task<IActionResult> DeleteHome(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5237/api/Home/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AHome");
            }
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> UpdateHome(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5237/api/Home/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateHomeDto>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> UpdateHome(UpdateHomeDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5237/api/Home/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AHome");
            }
            return View();
        }
    }
}
