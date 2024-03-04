using Mekel.BusinessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryService _galleryService;

        public GalleryController(IGalleryService galleryService) 
        {
            _galleryService = galleryService;
        }

        [HttpGet]
        public IActionResult GalleryList()
        {
            var values=_galleryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetGallery(int id)
        {
            var values=_galleryService.TGetByID(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGallery(int id)
        {
            var values = _galleryService.TGetByID(id);
            _galleryService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGallery(Gallery gallery)
        {
            _galleryService.TUpdate(gallery);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddGallery(Gallery gallery)
        {
            _galleryService.TInsert(gallery);
            return Ok();
        }
    }
}
