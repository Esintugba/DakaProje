using Mekel.BusinessLayer.Abstract;
using Mekel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mekel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public IActionResult ReservationList()
        {
            var values=_reservationService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetReservation(int id)
        {
            var values=_reservationService.TGetByID(id);
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(int id)
        {
            var values = _reservationService.TGetByID(id);
            _reservationService.TDelete(values);
            return Ok();
        }

        [HttpPut("UpdateReservation")]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            _reservationService.TUpdate(reservation);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            _reservationService.TInsert(reservation);
            return Ok();
        }

        [HttpGet("Last6Reservation")]
        public IActionResult Last6Reservation()
        {
            var values = _reservationService.TLast6Reservations();
            return Ok(values);
        }

        [HttpGet("ReservationAproved")]
        public IActionResult ReservationAproved(int id)
        {
            _reservationService.TReservationStatusChangeApproved3(id);
            return Ok();
        }

        [HttpGet("ReservationCancel")]
        public IActionResult ReservationCancel(int id)
        {
            _reservationService.TReservationStatusChangeCancel(id);
            return Ok();
        }

        [HttpGet("ReservationWait")]
        public IActionResult ReservationWait(int id)
        {
            _reservationService.TReservationStatusChangeWait(id);
            return Ok();
        }
    }
}
