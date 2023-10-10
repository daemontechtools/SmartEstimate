namespace SmartEstimate.Models;

public class Room
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Product> Products { get; set; } = new();
}

