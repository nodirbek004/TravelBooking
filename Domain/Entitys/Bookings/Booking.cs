using Domain.Commons.AudiTable;

namespace Domain.Entitys.Bookings;

public class Booking:AudiTable
{
    public long CostumerId { get; set; }
    public long TravelId { get; set; }
    public DateTime BookingData { get; set; }

}
