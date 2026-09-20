
using Introduction.Interfaces;
using Introduction.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//In Real time where we can use here 
builder.Services.AddSingleton<ISingletonCoffee, CoffeeService>();


//In real time exactly we  can use here
builder.Services.AddScoped<IScopedCoffee, CoffeeService>();


//In Real time exactly we can use here 
builder.Services.AddTransient<ITransientCoffee, CoffeeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
