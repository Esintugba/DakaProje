using Mekel.BusinessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        private readonly IChefService _chefService;

        public ChefController(IChefService chefService) 
        {
            _chefService = chefService;
        }

        [HttpGet]
        public IActionResult ChefList()
        {
            var values=_chefService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetChef(int id)
        {
            var values=_chefService.TGetByID(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteChef(int id)
        {
            var values = _chefService.TGetByID(id);
            _chefService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateChef(Chef chef)
        {
            _chefService.TUpdate(chef);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddChef(Chef chef)
        {
            _chefService.TInsert(chef);
            return Ok();
        }
    }
}
