using Mekel.BusinessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public IActionResult MenuList()
        {
            var values=_menuService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var values = _menuService.TGetByID(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMenu(int id)
        {
            var values = _menuService.TGetByID(id);
            _menuService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateMenu(Menu menu)
        {
            _menuService.TUpdate(menu);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddMenu(Menu menu)
        {
            _menuService.TInsert(menu);
            return Ok();
        }
    }
}
