namespace Reservation.Hotels.CQRS.Commands
{
    public class UpdateCommandLocation
    {
        public int LocationId { get; set; }
        public string LocationCity { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
