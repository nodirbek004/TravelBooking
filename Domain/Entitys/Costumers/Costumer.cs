using Domain.Commons.AudiTable;
using System.Globalization;

namespace Domain.Entitys.Costumers;

public class Costumer:AudiTable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string priceSum { get; set; }
}