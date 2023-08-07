namespace DaTaAccess.IRepasitories.Commons;

public interface IUNitOfWork
{
    IBookingRepasitory BookingRepasitory { get; }
    ICustomerRepasitory CustomerRepasitory { get; }
    ITravelPackegeRepasitory TravelPackege { get; }
    IPaymentRepasitory PaymentRepasitory { get; }
    Task<int> SaveAsync();
}
