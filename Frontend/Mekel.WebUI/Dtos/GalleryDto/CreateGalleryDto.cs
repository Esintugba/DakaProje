using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.GalleryDto
{
    public class CreateGalleryDto
    {
        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }
    }
}
