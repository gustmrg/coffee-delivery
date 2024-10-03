using CoffeeDelivery.API.Enums;
using CoffeeDelivery.API.Extensions;
using CoffeeDelivery.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeDelivery.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Coffee> Coffees => Set<Coffee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        foreach(var entity in modelBuilder.Model.GetEntityTypes())
        {
            // Replace table names
            entity.SetTableName(entity.GetTableName().ToSnakeCase());

            // Replace column names            
            foreach(var property in entity.GetProperties())
            {
                var columnName = property.GetColumnName(StoreObjectIdentifier.Table(property.DeclaringEntityType.GetTableName(), null));
                property.SetColumnName(columnName.ToSnakeCase());
            }

            foreach(var key in entity.GetKeys())
            {
                key.SetName(key.GetName().ToSnakeCase());
            }

            foreach(var key in entity.GetForeignKeys())
            {
                key.SetConstraintName(key.GetConstraintName().ToSnakeCase());
            }

            foreach(var index in entity.GetIndexes())
            {
                index.SetDatabaseName(index.GetDatabaseName().ToSnakeCase());
            }
        }
        
        # region Seed data
        
        modelBuilder.Entity<Coffee>().HasData(
            new Coffee
            {
                Id = 1, 
                Name = "Expresso Tradicional", 
                Description = "O tradicional café feito com água quente e grãos moídos",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = false,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 2, 
                Name = "Expresso Americano", 
                Description = "Expresso diluído, menos intenso que o tradicional",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = false,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 3, 
                Name = "Expresso Cremoso", 
                Description = "Café expresso tradicional com espuma cremosa",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = false,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 4, 
                Name = "Café com Leite", 
                Description = "Meio a meio expresso tradicional com leite vaporizado",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = true,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 5, 
                Name = "Latte", 
                Description = "Uma dose de café expresso com o dobro de leite e espuma cremosa",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = true,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 6, 
                Name = "Capuccino", 
                Description = "Bebida com canela feita de doses iguais de café, leite e espuma",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = true,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 7, 
                Name = "Mocaccino", 
                Description = "Café expresso com calda de chocolate, pouco leite e espuma",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Traditional,
                Price = 9.90M,
                HasMilk = true,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 8, 
                Name = "Chocolate Quente", 
                Description = "Bebida feita com chocolate dissolvido no leite quente e café",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Special,
                Price = 9.90M,
                HasMilk = true,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 9, 
                Name = "Cubano", 
                Description = "Drink gelado de café expresso com rum, creme de leite e hortelã",
                Temperature = Temperature.Cold,
                CoffeeType = CoffeeType.Special,
                Price = 9.90M,
                HasMilk = false,
                IsAlcoholic = true
            },
            new Coffee
            {
                Id = 10, 
                Name = "Árabe", 
                Description = "Bebida preparada com grãos de café árabe e especiarias",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Special,
                Price = 9.90M,
                HasMilk = false,
                IsAlcoholic = false
            },
            new Coffee
            {
                Id = 11, 
                Name = "Irlandês", 
                Description = "Bebida a base de café, uísque irlandês, açúcar e chantilly",
                Temperature = Temperature.Hot,
                CoffeeType = CoffeeType.Special,
                Price = 9.90M,
                HasMilk = false,
                IsAlcoholic = true
            });
        
        #endregion
    }
}