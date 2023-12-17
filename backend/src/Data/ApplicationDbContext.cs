using CoffeeDelivery.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeDelivery.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Coffee> Coffees => Set<Coffee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coffee>().HasKey(c => c.Id);
        
        modelBuilder.Entity<Coffee>()
            .Property(c => c.Price)
            .HasConversion<double>();
        
        base.OnModelCreating(modelBuilder);
    }
}