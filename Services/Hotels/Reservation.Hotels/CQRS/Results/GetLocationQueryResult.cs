namespace Reservation.Hotels.CQRS.Results
{
    public class GetLocationQueryResult
    {
        public int LocationId { get; set; }
        public string LocationCity { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
