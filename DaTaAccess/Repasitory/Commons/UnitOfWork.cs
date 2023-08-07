using DaTaAccess.DbContexts;
using DaTaAccess.IRepasitories;
using DaTaAccess.IRepasitories.Commons;

namespace DaTaAccess.Repasitory.Commons;

public class UnitOfWork : IUNitOfWork
{
    private readonly AppDbContext appDbContext;
    public UnitOfWork()
    {
        appDbContext = new AppDbContext();
    }
        

        
    public IBookingRepasitory BookingRepasitory => throw new NotImplementedException();

    public ICustomerRepasitory CustomerRepasitory => throw new NotImplementedException();

    public ITravelPackegeRepasitory TravelPackege => throw new NotImplementedException();

    public IPaymentRepasitory PaymentRepasitory => throw new NotImplementedException();

    public async Task<int> SaveAsync()
        =>await this.appDbContext.SaveChangesAsync();


}
