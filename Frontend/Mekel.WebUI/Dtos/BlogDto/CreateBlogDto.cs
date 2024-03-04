using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.BlogDto
{
    public class CreateBlogDto
    {
        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Text { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string BlogImage { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public DateTime Date { get; set; }
    }
}
