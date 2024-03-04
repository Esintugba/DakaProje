using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.ChefDto
{
    public class UpdateChefDto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Unvan { get; set; }

        public string Twitter { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Linkedln { get; set; }
    }
}
