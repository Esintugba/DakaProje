using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.GalleryDto
{
    public class UpdateGalleryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }
    }
}
