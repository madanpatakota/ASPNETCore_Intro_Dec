using Introduction.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeV2Repositoty, InMemoryEmployeeRepositoty>();
// IemployeeV2Repositoty  repo = new InMemoryEmployeeRepositoty();



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
