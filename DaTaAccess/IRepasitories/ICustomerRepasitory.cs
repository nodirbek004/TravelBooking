using DaTaAccess.IRepasitories.Commons;
using Domain.Entitys.Costumers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTaAccess.IRepasitories
{
    public interface ICustomerRepasitory: IRepasitories<Costumer>
    {
        IQueryable<Costumer> SearchByName(string name);
    }
}
