using SmartEstimate.Models;

namespace SmartEstimate.Mock;

public static class MockQuote {

    public static Dictionary<int, Quote> GetMockQuoteDict()
    {
        return new Dictionary<int, Quote>
        {
            { 1, new Quote {
                Id = 1,
                Name = "Quote 1",
                SalesAssociate = "John Doe",
                ContactInfo = "johndoe@example.com",
                DealerAddress = new ShippingAddress {
                    Name = "Dealer 1",
                    Line1 = "123 Main St",
                    Line2 = "",
                    City = "Toronto",
                    Ontario = "ON",
                    PostalCode = "M1M 1M1"
                },
                CustomerAddress = new ShippingAddress {
                    Name = "Customer 1",
                    Line1 = "456 Elm St",
                    Line2 = "",
                    City = "Mississauga",
                    Ontario = "ON",
                    PostalCode = "L5L 5L5"
                },
                IsPickup = true,
                IsDelivery = false,
                IsDealer = true,
                IsApartment = false,
                IsMultiLevel = false,
                IsFreightForwarder = false,
                QuoteStatus = "Pending",
                CatelogPdfUrl = "https://example.com/catalog.pdf",
                Rooms = new List<Room> {
                    new Room {
                        Id = 1,
                        Name = "Room 1",
                        DoorStyle = new DoorStyle {
                            Id = 1,
                            Name = "Style 1",
                            Price = 100.0f
                        },
                        Finish = new Finish {
                            Id = 1,
                            Name = "Finish 1",
                            Price = 50.0f
                        },
                        Interior = new Interior {
                            Id = 1,
                            Name = "Interior 1",
                            Price = 75.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 1,
                            Name = "Hardware 1",
                            Price = 25.0f
                        },
                        SubTotal = 250.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 1,
                                Code = "P1",
                                Width = 10.0f,
                                Height = 20.0f,
                                Depth = 5.0f,
                                Left = true,
                                Right = false,
                                Int = 1,
                                Comments = "",
                                Price = 100.0f,
                                EXT = "",
                                Name = "Product 1"
                            },
                            new Product {
                                Id = 2,
                                Code = "P2",
                                Width = 15.0f,
                                Height = 25.0f,
                                Depth = 10.0f,
                                Left = false,
                                Right = true,
                                Int = 2,
                                Comments = "",
                                Price = 150.0f,
                                EXT = "",
                                Name = "Product 2"
                            }
                        }
                    }
                }
            }},
            { 2, new Quote {
                Id = 2,
                Name = "Quote 2",
                SalesAssociate = "Jane Smith",
                ContactInfo = "janesmith@example.com",
                DealerAddress = new ShippingAddress {
                    Name = "Dealer 2",
                    Line1 = "789 Oak St",
                    Line2 = "",
                    City = "Vancouver",
                    Ontario = "BC",
                    PostalCode = "V6H 1K2"
                },
                CustomerAddress = new ShippingAddress {
                    Name = "Customer 2",
                    Line1 = "321 Pine St",
                    Line2 = "",
                    City = "Burnaby",
                    Ontario = "BC",
                    PostalCode = "V5G 1A1"
                },
                IsPickup = false,
                IsDelivery = true,
                IsDealer = false,
                IsApartment = true,
                IsMultiLevel = false,
                IsFreightForwarder = false,
                QuoteStatus = "Accepted",
                CatelogPdfUrl = "https://example.com/catalog.pdf",
                Rooms = new List<Room> {
                    new Room {
                        Id = 1,
                        Name = "Room 1",
                        DoorStyle = new DoorStyle {
                            Id = 1,
                            Name = "Style 1",
                            Price = 100.0f
                        },
                        Finish = new Finish {
                            Id = 1,
                            Name = "Finish 1",
                            Price = 50.0f
                        },
                        Interior = new Interior {
                            Id = 1,
                            Name = "Interior 1",
                            Price = 75.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 1,
                            Name = "Hardware 1",
                            Price = 25.0f
                        },
                        SubTotal = 250.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 1,
                                Code = "P1",
                                Width = 10.0f,
                                Height = 20.0f,
                                Depth = 5.0f,
                                Left = true,
                                Right = false,
                                Int = 1,
                                Comments = "",
                                Price = 100.0f,
                                EXT = "",
                                Name = "Product 1"
                            },
                            new Product {
                                Id = 2,
                                Code = "P2",
                                Width = 15.0f,
                                Height = 25.0f,
                                Depth = 10.0f,
                                Left = false,
                                Right = true,
                                Int = 2,
                                Comments = "",
                                Price = 150.0f,
                                EXT = "",
                                Name = "Product 2"
                            }
                        }
                    },
                    new Room {
                        Id = 2,
                        Name = "Room 2",
                        DoorStyle = new DoorStyle {
                            Id = 2,
                            Name = "Style 2",
                            Price = 200.0f
                        },
                        Finish = new Finish {
                            Id = 2,
                            Name = "Finish 2",
                            Price = 100.0f
                        },
                        Interior = new Interior {
                            Id = 2,
                            Name = "Interior 2",
                            Price = 150.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 2,
                            Name = "Hardware 2",
                            Price = 50.0f
                        },
                        SubTotal = 500.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 3,
                                Code = "P3",
                                Width = 20.0f,
                                Height = 30.0f,
                                Depth = 15.0f,
                                Left = true,
                                Right = false,
                                Int = 3,
                                Comments = "",
                                Price = 200.0f,
                                EXT = "",
                                Name = "Product 3"
                            },
                            new Product {
                                Id = 4,
                                Code = "P4",
                                Width = 25.0f,
                                Height = 35.0f,
                                Depth = 20.0f,
                                Left = false,
                                Right = true,
                                Int = 4,
                                Comments = "",
                                Price = 300.0f,
                                EXT = "",
                                Name = "Product 4"
                            }
                        }
                    }
                }
            }}
        };
    }
}
