using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebUI.Controllers
{
    [AllowAnonymous]
    public class ErrorPageController : Controller
    {
        
        public IActionResult Error404()
        {
            return View();
        }
    }
}
