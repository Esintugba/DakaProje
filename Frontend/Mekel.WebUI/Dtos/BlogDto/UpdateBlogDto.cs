using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.BlogDto
{
    public class UpdateBlogDto
    {
        public int Id { get; set; }

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
