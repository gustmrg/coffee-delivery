using CoffeeDelivery.API.Enums;

namespace CoffeeDelivery.API.Models;

public class Coffee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Temperature Temperature { get; set; }
    public CoffeeType CoffeeType { get; set; }
    public decimal Price { get; set; }
    public bool HasMilk { get; set; }
    public bool IsAlcoholic { get; set; }
}