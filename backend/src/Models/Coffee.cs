using CoffeeDelivery.API.Enums;

namespace CoffeeDelivery.API.Models;

public class Coffee
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; } = string.Empty;
    public Temperature Temperature { get; set; }
    public Category Category { get; set; }
    public decimal Price { get; set; }
    public bool HasMilk { get; set; }
    public bool HasAlcohol { get; set; }
}