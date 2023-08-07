using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Costumer;

public class CustomerCreateDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string priceSum { get; set; }
}
