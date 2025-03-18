using Microsoft.EntityFrameworkCore;
using Reservation.Hotels.Entities;

namespace Reservation.Hotels.Context
{
    public class HotelContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=1440,localhost; initial catalog=HotelReservationDb; User=sa; password=123456Aa*");
        }

        public DbSet<HotelInfo> HotelInfos { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}