using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez!")]
        public string Password { get; set; }
    }
}
