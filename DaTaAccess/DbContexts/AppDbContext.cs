using Domain.Entitys.Bookings;
using Domain.Entitys.Costumers;
using Domain.Entitys.Travelpackage;
using Microsoft.EntityFrameworkCore;

namespace DaTaAccess.DbContexts;

public class AppDbContext : DbContext
{
    DbSet<Costumer> Costumers { get; set; }
    DbSet<TravelPackege> TravelPackeges { get; set; }
    DbSet<Booking> Bookings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Host=localhost;Port=5432;User Id=postgres;Database=TravelBooking;Password=2004";
        optionsBuilder.UseNpgsql(path);
    }
}
