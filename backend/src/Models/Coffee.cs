using CoffeeDelivery.API.Enums;

namespace CoffeeDelivery.API.Models;

public class Coffee
{
    public Coffee() { }
    
    public Coffee(int id, string name, Temperature temperature, Category category, decimal price, bool hasMilk, bool hasAlcohol)
    {
        Id = id;
        Name = name;
        Temperature = temperature;
        Category = category;
        Price = price;
        HasMilk = hasMilk;
        HasAlcohol = hasAlcohol;
    }
    
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; } = string.Empty;
    public Temperature Temperature { get; set; }
    public Category Category { get; set; }
    public decimal Price { get; set; }
    public bool HasMilk { get; set; }
    public bool HasAlcohol { get; set; }
}