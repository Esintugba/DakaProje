using Mekel.DataAccessLayer.Concrete;
using Mekel.WebUI.Dtos.AboutDto;
using Mekel.WebUI.Dtos.ContactDto;
using Mekel.WebUI.Dtos.HomeDto;
using Mekel.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace Mekel.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
       
        public async Task<IActionResult> IndexAsync()
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

        public async Task<IActionResult> Partial1Async()

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
        public PartialViewResult Partial2()
        {
         
            return PartialView();
        }
        public PartialViewResult Partial3()
        {
            return PartialView();
        }
        public PartialViewResult Partial4()
        {  
            return PartialView();
        }
        public PartialViewResult Partial5()
        {    
            return PartialView();
        }
        public PartialViewResult Partial6()
        {     
            return PartialView();
        }
        public PartialViewResult Partial7()
        { 
            return PartialView();
        }
        public PartialViewResult Partial8()

        {      
            return PartialView();
        }
        public PartialViewResult Partial9()

        {
            return PartialView();
        }
        public PartialViewResult Partial10()

        {
            return PartialView();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
