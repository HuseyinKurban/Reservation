using Reservation.Hotels.Context;
using Reservation.Hotels.CQRS.Queries;
using Reservation.Hotels.CQRS.Results;

namespace Reservation.Hotels.CQRS.Handlers
{
    public class GetByIdLocationQueryHandler
    {
        private readonly HotelContext _context;

        public GetByIdLocationQueryHandler(HotelContext context)
        {
            _context = context;
        }

        public GetByIdLocationQueryResult Handle(GetByIdLocationQuery query)
        {
            var value = _context.Locations.Find(query.LocationId);
            return new GetByIdLocationQueryResult
            {
                Country = value.Country,
                District = value.District,
                LocationCity = value.LocationCity,
                LocationId = value.LocationId
            };
         
        }
    }
}
