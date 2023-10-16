using Daemon.DataStore;


namespace SmartEstimate.Models;

public struct Room : IDbModel
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public string Name { get; set; }
    public DoorStyle DoorStyle { get; set; }
    public Finish  Finish { get; set; }
    public Interior Interior { get; set; }
    public DrawerHardware DrawerHardware { get; set; }
    public float SubTotal { get; set; }
    public List<Product> Products { get; set; }
}

