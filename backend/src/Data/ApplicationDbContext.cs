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
        modelBuilder.Entity<Coffee>()
            .HasKey(c => c.Id)
            .HasName("coffee_id");
        
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
        
        base.OnModelCreating(modelBuilder);
    }
}