using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description1 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description2 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description3 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description4 { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }
    }
}
