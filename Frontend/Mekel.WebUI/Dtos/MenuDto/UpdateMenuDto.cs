using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.MenuDto
{
    public class UpdateMenuDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public int CategoryId { get; set; }
    }
}
