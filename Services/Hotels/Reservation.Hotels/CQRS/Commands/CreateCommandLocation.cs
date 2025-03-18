namespace Reservation.Hotels.CQRS.Commands
{
    public class CreateCommandLocation
    {
        public string LocationCity { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
    }
}
