using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Results;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class GetLocationQueryHandler
    {
        private readonly HotelContext _context;

        public GetLocationQueryHandler(HotelContext context)
        {
            _context = context;
        }

        public List<GetLocationQueryResult> Handle()
        {
            var values = _context.Locations.Select(x => new GetLocationQueryResult
            {
                Country = x.Country,
                District = x.District,
                LocationCity = x.LocationCity,
                LocationId = x.LocationId
            }).ToList();

            return values;
        }
    }
}
