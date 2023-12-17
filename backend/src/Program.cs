using CoffeeDelivery.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connection));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/coffees", async (ApplicationDbContext _context) =>
    {
        var coffees = await _context.Coffees.AsNoTracking().ToListAsync();
        return coffees;
    })
.WithName("GetCoffees")
.WithOpenApi();

app.Run();
