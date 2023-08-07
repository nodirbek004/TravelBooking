using Domain.Commons.AudiTable;

namespace Domain.Entitys.Payments;

public class Payment:AudiTable
{
    public string quantity { get; set; }
    public string amount { get; set; }
    public string description { get; set; }

}
