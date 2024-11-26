using System;

namespace LearnifyStockApp.Models.Entities;

public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Contact { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
