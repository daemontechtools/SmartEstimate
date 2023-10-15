namespace SmartEstimate.Models;

public struct Finish {
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }

    public DbProps DbProps{ get; set; }
}