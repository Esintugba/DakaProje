using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.HomeDto
{
    public class UpdateHomeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }
    }
}
