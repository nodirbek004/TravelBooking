namespace Service.DTOs.Booking;

public class BookingCreateDTO
{
    public long CostumerId { get; set; }
    public long TravelId { get; set; }
    public DateTime BookingData { get; set; }
}
