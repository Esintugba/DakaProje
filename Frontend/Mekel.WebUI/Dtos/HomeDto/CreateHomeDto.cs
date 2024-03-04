using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.HomeDto
{
    public class CreateHomeDto
    {
        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }
    }
}
