namespace SmartEstimate.Models;

public struct Interior
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }

    public DbProps DbProps{ get; set; }
}