using Introduction.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IEmployeeV3Repositoty, InMemoryEmployeev3Repositoty>();
// IemployeeV2Repositoty  repo = new InMemoryEmployeeRepositoty();
//addsingleton
//addtransistent





var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
