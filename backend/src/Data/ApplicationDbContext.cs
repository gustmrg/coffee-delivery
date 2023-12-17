using CoffeeDelivery.API.Enums;
using CoffeeDelivery.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeDelivery.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Coffee> Coffees => Set<Coffee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coffee>()
            .HasKey(c => c.Id)
            .HasName("coffee_id");
        
        modelBuilder.Entity<Coffee>()
            .Property(c => c.Id)
            .HasColumnName("coffee_id");
        
        modelBuilder.Entity<Coffee>().Property(c => c.Name)
            .HasColumnName("name")
            .HasMaxLength(250)
            .IsRequired();
        
        modelBuilder.Entity<Coffee>().Property(c => c.Description)
            .HasColumnName("description")
            .HasMaxLength(1000);
        
        modelBuilder.Entity<Coffee>()
            .Property(c => c.Price)
            .HasConversion<double>()
            .HasColumnName("price")
            .IsRequired();
        
        modelBuilder.Entity<Coffee>().Property(c => c.Temperature)
            .HasColumnName("temperature")
            .IsRequired();
        
        modelBuilder.Entity<Coffee>().Property(c => c.Category)
            .HasColumnName("category")
            .IsRequired();
        
        modelBuilder.Entity<Coffee>().Property(c => c.HasMilk)
            .HasColumnName("has_milk")
            .IsRequired();
        
        modelBuilder.Entity<Coffee>().Property(c => c.HasAlcohol)
            .HasColumnName("has_alcohol")
            .IsRequired();

        modelBuilder.Entity<Coffee>().ToTable("coffees");

        #region Seed data
        
        modelBuilder.Entity<Coffee>().HasData(
            new Coffee
            {
                Id = 1, 
                Name = "Expresso Tradicional", 
                Description = "O tradicional café feito com água quente e grãos moídos",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = false,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 2, 
                Name = "Expresso Americano", 
                Description = "Expresso diluído, menos intenso que o tradicional",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = false,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 3, 
                Name = "Expresso Cremoso", 
                Description = "Café expresso tradicional com espuma cremosa",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = false,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 4, 
                Name = "Café com Leite", 
                Description = "Meio a meio expresso tradicional com leite vaporizado",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = true,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 5, 
                Name = "Latte", 
                Description = "Uma dose de café expresso com o dobro de leite e espuma cremosa",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = true,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 6, 
                Name = "Capuccino", 
                Description = "Bebida com canela feita de doses iguais de café, leite e espuma",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = true,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 7, 
                Name = "Mocaccino", 
                Description = "Café expresso com calda de chocolate, pouco leite e espuma",
                Temperature = Temperature.Hot,
                Category = Category.Traditional,
                Price = 9.90M,
                HasMilk = true,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 8, 
                Name = "Chocolate Quente", 
                Description = "Bebida feita com chocolate dissolvido no leite quente e café",
                Temperature = Temperature.Hot,
                Category = Category.Special,
                Price = 9.90M,
                HasMilk = true,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 9, 
                Name = "Cubano", 
                Description = "Drink gelado de café expresso com rum, creme de leite e hortelã",
                Temperature = Temperature.Cold,
                Category = Category.Special,
                Price = 9.90M,
                HasMilk = false,
                HasAlcohol = true
            },
            new Coffee
            {
                Id = 10, 
                Name = "Árabe", 
                Description = "Bebida preparada com grãos de café árabe e especiarias",
                Temperature = Temperature.Hot,
                Category = Category.Special,
                Price = 9.90M,
                HasMilk = false,
                HasAlcohol = false
            },
            new Coffee
            {
                Id = 11, 
                Name = "Irlandês", 
                Description = "Bebida a base de café, uísque irlandês, açúcar e chantilly",
                Temperature = Temperature.Hot,
                Category = Category.Special,
                Price = 9.90M,
                HasMilk = false,
                HasAlcohol = true
            });
        
        #endregion 
        
        base.OnModelCreating(modelBuilder);
    }
}