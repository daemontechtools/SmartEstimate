using Daemon.DataStore;


namespace SmartEstimate.Models;

public struct ShippingAddress : IDbModel {

    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public string Name { get; set; }
    public string Line1 { get; set; }
    public string Line2 { get; set; }
    public string City { get; set; }
    public string Ontario { get; set; }
    public string PostalCode { get; set; }
}