using Service.DTOs.Booking;
using Service.DTOs.Payment;
using Service.Helpers;

namespace Service.Interfaces.Payment;

public interface IPaymentService
{
    Task<Responce<IEnumerable<PaymentResultDTO>>> GetAllAsync();
}
