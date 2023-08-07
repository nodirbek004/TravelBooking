using DaTaAccess.IRepasitories.Commons;
using Domain.Entitys.Costumers;
using Domain.Entitys.Payments;

namespace DaTaAccess.IRepasitories;

public interface IPaymentRepasitory : IRepasitories<Payment>
{
    IQueryable<Payment> SearchByQuantity(string quantity);

}
