namespace SmartEstimate.Models;


public abstract class DbProps
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}