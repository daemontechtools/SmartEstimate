using Daemon.DataStore;


namespace SmartEstimate.Models;

public struct QuoteMock : IModelMockData<Quote> {

    public QuoteMock() {}

    public List<Quote> MockModels { get; set; }
        = new List<Quote>
        {
            new Quote {
                Id = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
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
                Status = QuoteStatus.Draft,
                CatelogPdfUrl = "https://example.com/catalog.pdf",
                Rooms = new List<Room> {
                    new Room {
                        Id = 2,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        Name = "Room 1",
                        DoorStyle = new DoorStyle {
                            Id = 3,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Style 1",
                            Price = 100.0f
                        },
                        Finish = new Finish {
                            Id = 4,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Finish 1",
                            Price = 50.0f
                        },
                        Interior = new Interior {
                            Id = 5,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Interior 1",
                            Price = 75.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 6,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Hardware 1",
                            Price = 25.0f
                        },
                        SubTotal = 250.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 6,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now,
                                Code = "P1",
                                Width = 10.0f,
                                Height = 20.0f,
                                Depth = 5.0f,
                                Left = true,
                                Right = false,
                                Comments = "",
                                Price = 100.0f,
                                EXT = "",
                                Name = "Product 1"
                            },
                            new Product {
                                Id = 7,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now,
                                Code = "P2",
                                Width = 15.0f,
                                Height = 25.0f,
                                Depth = 10.0f,
                                Left = false,
                                Right = true,
                                Comments = "",
                                Price = 150.0f,
                                EXT = "",
                                Name = "Product 2"
                            }
                        }
                    }
                }
            },
            new Quote {
                Id = 10,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
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
                Status = QuoteStatus.Draft,
                CatelogPdfUrl = "https://example.com/catalog.pdf",
                Rooms = new List<Room> {
                    new Room {
                        Id = 7,
                        Name = "Room 1",
                        DoorStyle = new DoorStyle {
                            Id = 5,
                            Name = "Style 1",
                            Price = 100.0f
                        },
                        Finish = new Finish {
                            Id = 6,
                            Name = "Finish 1",
                            Price = 50.0f
                        },
                        Interior = new Interior {
                            Id = 7,
                            Name = "Interior 1",
                            Price = 75.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 8,
                            Name = "Hardware 1",
                            Price = 25.0f
                        },
                        SubTotal = 250.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 9,
                                Code = "P1",
                                Width = 10.0f,
                                Height = 20.0f,
                                Depth = 5.0f,
                                Left = true,
                                Right = false,
                                Comments = "",
                                Price = 100.0f,
                                EXT = "",
                                Name = "Product 1"
                            },
                            new Product {
                                Id = 10,
                                Code = "P2",
                                Width = 15.0f,
                                Height = 25.0f,
                                Depth = 10.0f,
                                Left = false,
                                Right = true,
                                Comments = "",
                                Price = 150.0f,
                                EXT = "",
                                Name = "Product 2"
                            }
                        }
                    },
                    new Room {
                        Id = 11,
                        Name = "Room 2",
                        DoorStyle = new DoorStyle {
                            Id = 12,
                            Name = "Style 2",
                            Price = 200.0f
                        },
                        Finish = new Finish {
                            Id = 13,
                            Name = "Finish 2",
                            Price = 100.0f
                        },
                        Interior = new Interior {
                            Id = 14,
                            Name = "Interior 2",
                            Price = 150.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 15,
                            Name = "Hardware 2",
                            Price = 50.0f
                        },
                        SubTotal = 500.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 16,
                                Code = "P3",
                                Width = 20.0f,
                                Height = 30.0f,
                                Depth = 15.0f,
                                Left = true,
                                Right = false,
                                Comments = "",
                                Price = 200.0f,
                                EXT = "",
                                Name = "Product 3"
                            },
                            new Product {
                                Id = 17,
                                Code = "P4",
                                Width = 25.0f,
                                Height = 35.0f,
                                Depth = 20.0f,
                                Left = false,
                                Right = true,
                                Comments = "",
                                Price = 300.0f,
                                EXT = "",
                                Name = "Product 4"
                            }
                        }
                    }
                }
            },
            new Quote {
                Id = 3,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Name = "Quote 3",
                SalesAssociate = "Bob Johnson",
                ContactInfo = "bobjohnson@example.com",
                DealerAddress = new ShippingAddress {
                    Id = 4,
                    Name = "Dealer 3",
                    Line1 = "456 Main St",
                    Line2 = "",
                    City = "Vancouver",
                    Ontario = "BC",
                    PostalCode = "V6H 1K2"
                },
                CustomerAddress = new ShippingAddress {
                    Id = 5,
                    Name = "Customer 3",
                    Line1 = "789 Pine St",
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
                Status = QuoteStatus.Draft,
                CatelogPdfUrl = "https://example.com/catalog.pdf",
                Rooms = new List<Room> {
                    new Room {
                        Id = 6,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        Name = "Room 1",
                        DoorStyle = new DoorStyle {
                            Id = 7,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Style 1",
                            Price = 100.0f
                        },
                        Finish = new Finish {
                            Id = 8,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Finish 1",
                            Price = 50.0f
                        },
                        Interior = new Interior {
                            Id = 9,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Interior 1",
                            Price = 75.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 10,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Hardware 1",
                            Price = 25.0f
                        },
                        SubTotal = 250.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 11,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now,
                                Code = "P1",
                                Width = 10.0f,
                                Height = 20.0f,
                                Depth = 5.0f,
                                Left = true,
                                Right = false,
                                Comments = "",
                                Price = 100.0f,
                                EXT = "",
                                Name = "Product 1"
                            },
                            new Product {
                                Id = 12,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now,
                                Code = "P2",
                                Width = 15.0f,
                                Height = 25.0f,
                                Depth = 10.0f,
                                Left = false,
                                Right = true,
                                Comments = "",
                                Price = 150.0f,
                                EXT = "",
                                Name = "Product 2"
                            }
                        }
                    },
                    new Room {
                        Id = 13,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        Name = "Room 2",
                        DoorStyle = new DoorStyle {
                            Id = 14,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Style 2",
                            Price = 200.0f
                        },
                        Finish = new Finish {
                            Id = 15,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Finish 2",
                            Price = 100.0f
                        },
                        Interior = new Interior {
                            Id = 16,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Interior 2",
                            Price = 150.0f
                        },
                        DrawerHardware = new DrawerHardware {
                            Id = 17,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Name = "Hardware 2",
                            Price = 50.0f
                        },
                        SubTotal = 500.0f,
                        Products = new List<Product> {
                            new Product {
                                Id = 18,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now,
                                Code = "P3",
                                Width = 20.0f,
                                Height = 30.0f,
                                Depth = 15.0f,
                                Left = true,
                                Right = false,
                                Comments = "",
                                Price = 200.0f,
                                EXT = "",
                                Name = "Product 3"
                            },
                            new Product {
                                Id = 19,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now,
                                Code = "P4",
                                Width = 25.0f,
                                Height = 35.0f,
                                Depth = 20.0f,
                                Left = false,
                                Right = true,
                                Comments = "",
                                Price = 300.0f,
                                EXT = "",
                                Name = "Product 4"
                            }
                        }
                    }
                }
            }
        };

    static public QuoteView GenerateRandomQuoteView() {
        var random = new Random();

        var quoteView = new QuoteView
        {
            Id = random.Next(1, 1000),
            CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
            UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
            Name = $"Quote {random.Next(1, 100)}",
            SalesAssociate = $"Sales Associate {random.Next(1, 10)}",
            ContactInfo = $"salesassociate{random.Next(1, 10)}@example.com",
            DealerAddress = new ShippingAddress
            {
                Name = $"Dealer {random.Next(1, 10)}",
                Line1 = $"{random.Next(1, 100)} Main St",
                Line2 = "",
                City = "Toronto",
                Ontario = "ON",
                PostalCode = $"M{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)} {random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}"
            },
            CustomerAddress = new ShippingAddress
            {
                Name = $"Customer {random.Next(1, 10)}",
                Line1 = $"{random.Next(1, 1000)} Elm St",
                Line2 = "",
                City = "Mississauga",
                Ontario = "ON",
                PostalCode = $"L{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)} {random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}"
            },
            IsPickup = random.Next(0, 2) == 1,
            IsDelivery = random.Next(0, 2) == 1,
            IsDealer = random.Next(0, 2) == 1,
            IsApartment = random.Next(0, 2) == 1,
            IsMultiLevel = random.Next(0, 2) == 1,
            IsFreightForwarder = random.Next(0, 2) == 1,
            Status = (QuoteStatus)random.Next(0, 4),
            CatelogPdfUrl = "https://example.com/catalog.pdf",
            Rooms = new List<Room>
            {
                new Room
                {
                    Id = random.Next(1, 1000),
                    CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                    UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                    Name = $"Room {random.Next(1, 10)}",
                    DoorStyle = new DoorStyle
                    {
                        Id = random.Next(1, 1000),
                        CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        Name = $"Style {random.Next(1, 10)}",
                        Price = (float)random.NextDouble() * 100
                    },
                    Finish = new Finish
                    {
                        Id = random.Next(1, 1000),
                        CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        Name = $"Finish {random.Next(1, 10)}",
                        Price = (float)random.NextDouble() * 100
                    },
                    Interior = new Interior
                    {
                        Id = random.Next(1, 1000),
                        CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        Name = $"Interior {random.Next(1, 10)}",
                        Price = (float)random.NextDouble() * 100
                    },
                    DrawerHardware = new DrawerHardware
                    {
                        Id = random.Next(1, 1000),
                        CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                        Name = $"Hardware {random.Next(1, 10)}",
                        Price = (float)random.NextDouble() * 100
                    },
                    SubTotal = (float)random.NextDouble() * 1000,
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Id = random.Next(1, 1000),
                            CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                            UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                            Code = $"P{random.Next(1, 10)}",
                            Width = (float)random.NextDouble() * 100,
                            Height = (float)random.NextDouble() * 100,
                            Depth = (float)random.NextDouble() * 100,
                            Left = random.Next(0, 2) == 1,
                            Right = random.Next(0, 2) == 1,
                            Comments = "",
                            Price = (float)random.NextDouble() * 100,
                            EXT = "",
                            Name = $"Product {random.Next(1, 10)}"
                        },
                        new Product
                        {
                            Id = random.Next(1, 1000),
                            CreatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                            UpdatedAt = DateTime.Now.AddDays(-random.Next(1, 30)),
                            Code = $"P{random.Next(1, 10)}",
                            Width = (float)random.NextDouble() * 100,
                            Height = (float)random.NextDouble() * 100,
                            Depth = (float)random.NextDouble() * 100,
                            Left = random.Next(0, 2) == 1,
                            Right = random.Next(0, 2) == 1,
                            Comments = "",
                            Price = (float)random.NextDouble() * 100,
                            EXT = "",
                            Name = $"Product {random.Next(1, 10)}"
                        }
                    }
                }
            }
        };

        return quoteView;
    }
}
