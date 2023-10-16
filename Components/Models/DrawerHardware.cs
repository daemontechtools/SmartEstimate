using Daemon.DataStore;


namespace SmartEstimate.Models;

public struct DrawerHardware : IDbModel
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public string Name { get; set; }
    public float Price { get; set; }
}