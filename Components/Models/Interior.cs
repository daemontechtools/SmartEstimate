using Daemon.DataAccess.DataStore;

namespace SmartEstimate.Models;

public struct Interior
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public string Name { get; set; }
    public float Price { get; set; }
}