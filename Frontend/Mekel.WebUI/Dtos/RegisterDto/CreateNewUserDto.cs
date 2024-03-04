using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
    }
}
