namespace Service.DTOs.TravelPackege;

public class TravelUpdateDto
{
    public string Name { get; set; }
    public string destination { get; set; }
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }
}
