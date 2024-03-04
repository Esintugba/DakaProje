using Mekel.BusinessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public IActionResult HomeList()
        {
            var values=_homeService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetHome(int id)
        {
            var values=_homeService.TGetByID(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHome(int id)
        {
            var values = _homeService.TGetByID(id);
            _homeService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateHome(Home home)
        {
            _homeService.TUpdate(home);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddHome(Home home)
        {
            _homeService.TInsert(home);
            return Ok();
        }
    }
}
