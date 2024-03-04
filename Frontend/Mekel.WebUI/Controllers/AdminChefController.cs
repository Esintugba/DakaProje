using Mekel.WebUI.Dtos.ChefDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Mekel.WebUI.Controllers
{
    public class AdminChefController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminChefController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> AChef()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5237/api/Chef");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultChefDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddChef()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddChef(CreateChefDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5237/api/Chef", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AChef");
            }
            return View();
        }

        public async Task<IActionResult> DeleteChef(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5237/api/Chef/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AChef");
            }
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> UpdateChef(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5237/api/Chef/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateChefDto>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> UpdateChef(UpdateChefDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5237/api/Chef/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AChef");
            }
            return View();
        }
    }
}
