using System.ComponentModel.DataAnnotations;

namespace Mekel.WebUI.Dtos.ReservationDto
{
    public class CreateReservationDto
    {



        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Time { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public int Person { get; set; }

        [Required(ErrorMessage = "This field cannot be left blank!")]
        public string Message { get; set; }
        public string Durum { get; set; }
    }
}
