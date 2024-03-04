using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebUI.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Menu()
        {
            return View();
        }

        public PartialViewResult Meal()
        {
            return PartialView();
        }
        public PartialViewResult Dessert()
        {
            return PartialView();
        }
        public PartialViewResult Drink()
        {
            return PartialView();
        }
    }
}
