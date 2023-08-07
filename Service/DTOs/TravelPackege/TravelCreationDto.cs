namespace Service.DTOs.TravelPackege;

public class TravelCreationDto
{
    public string Name { get; set; }
    public string destination { get; set; }
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }
}
