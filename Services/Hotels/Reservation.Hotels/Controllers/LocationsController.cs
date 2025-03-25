using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.Hotels.CQRS.Commands;
using Reservation.Hotels.CQRS.Handlers;

namespace Reservation.Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly CreateLocationCommandHandler _createLocationCommandHandler;
        private readonly RemoveLocationCommandHandler _removeLocationCommandHandler;
        private readonly GetLocationQueryHandler _getLocationQueryHandler;
        private readonly GetByIdLocationQueryHandler _getByIdLocationQueryHandler;
        private readonly UpdateLocationCommandHandler _updateLocationCommandHandler;

        public LocationsController(CreateLocationCommandHandler createLocationCommandHandler, RemoveLocationCommandHandler removeLocationCommandHandler, GetLocationQueryHandler getLocationQueryHandler, GetByIdLocationQueryHandler getByIdLocationQueryHandler, UpdateLocationCommandHandler updateLocationCommandHandler)
        {
            _createLocationCommandHandler = createLocationCommandHandler;
            _removeLocationCommandHandler = removeLocationCommandHandler;
            _getLocationQueryHandler = getLocationQueryHandler;
            _getByIdLocationQueryHandler = getByIdLocationQueryHandler;
            _updateLocationCommandHandler = updateLocationCommandHandler;
        }

        [HttpGet]
        public IActionResult LocationList()
        {
            var values=_getLocationQueryHandler.Handle();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateLocation(CreateCommandLocation command)
        {
            _createLocationCommandHandler.Handle(command);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteLocation(int id)
        {
            _removeLocationCommandHandler.Handle(new RemoveCommandLocation(id));
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateLocation(UpdateCommandLocation command)
        {
            _updateLocationCommandHandler.Handle(command);
            return Ok("Güncelleme Başarılı");
        }
    }
}
