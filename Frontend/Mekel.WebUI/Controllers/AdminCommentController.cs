using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebUI.Controllers
{
    public class AdminCommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
