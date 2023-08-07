using Domain.Commons.AudiTable;
using System.Globalization;

namespace Domain.Entitys.Travelpackage;

public class TravelPackege:AudiTable
{
    public string Name { get; set; }
    public string destination { get; set; }
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }

}
