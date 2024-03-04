using Mekel.WebUI.Dtos.MenuDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Mekel.WebUI.Controllers
{
    public class AdminMenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminMenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> AMenu()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5237/api/Menu");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMenuDto>>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpGet]
        public IActionResult AddMenu()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMenu(CreateMenuDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5237/api/Menu", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AMenu");
            }
            return View();
        }

        public async Task<IActionResult> DeleteMenu(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5237/api/Menu/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AMenu");
            }
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> UpdateMenu(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5237/api/Menu/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateMenuDto>(jsonData);
                return View(values);
            }
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> UpdateMenu(UpdateMenuDto model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5237/api/Menu/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AMenu");
            }
            return View();
        }
    }
}
