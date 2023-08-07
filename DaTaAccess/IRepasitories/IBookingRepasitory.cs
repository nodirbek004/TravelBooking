using DaTaAccess.IRepasitories.Commons;
using Domain.Entitys.Bookings;

namespace DaTaAccess.IRepasitories;

public interface IBookingRepasitory : IRepasitories<Booking>
{
    IQueryable<Booking> GetBySpecifyingDate(DateTime date);
}
