using DaTaAccess.IRepasitories.Commons;
using Domain.Entitys.Costumers;
using Domain.Entitys.Travelpackage;

namespace DaTaAccess.IRepasitories;

public interface ITravelPackegeRepasitory :IRepasitories<TravelPackege>
{
    IQueryable<TravelPackege> SearchByName(string name);

}
