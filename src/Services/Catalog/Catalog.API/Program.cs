using Catalog.Persistence.Database;
using Catalog.Services.Querries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add migration support
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")  // Configuración común a todos los entornos
    .AddJsonFile("appsettings.Development.json", optional: true)  // Configuración específica de desarrollo
    .Build();

    options.UseSqlServer(
        configuration.GetConnectionString("DefaultConnection"),
        x => x.MigrationsHistoryTable("_EFMigrationsHistory", "Catalog")
        );
});

builder.Services.AddTransient<IProductQuerryService, ProductQuerryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
