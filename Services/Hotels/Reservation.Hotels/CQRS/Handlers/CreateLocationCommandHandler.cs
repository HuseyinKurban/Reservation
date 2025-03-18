using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Commands;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class CreateLocationCommandHandler
    {
        private readonly HotelContext _context;

        public CreateLocationCommandHandler(HotelContext context)
        {
            _context = context;
        }

        public void Handle(CreateCommandLocation command)
        {
            _context.Locations.Add(new Entities.Location
            {

                Country = command.Country,
                District = command.District,
                LocationCity = command.LocationCity,
            });

            _context.SaveChanges();
        }
    }
}
