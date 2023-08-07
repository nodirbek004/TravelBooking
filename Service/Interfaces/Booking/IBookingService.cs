using Service.DTOs.Booking;
using Service.DTOs.TravelPackege;
using Service.Helpers;

namespace Service.Interfaces.Booking;

public interface IBookingService
{
    Task<BookingResultDTO> CreateAsync(BookingResultDTO result);
    Task<BookingResultDTO> UpdateAsync(BookingResultDTO result);
    Task<BookingResultDTO> GetByIdAsync(long id);
    Task<bool> DeleteAsync(long id);

    Task<Responce<IEnumerable<BookingResultDTO>>> GetAllAsync();
}
