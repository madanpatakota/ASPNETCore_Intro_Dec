
//using Introduction.Interfaces;
//using Introduction.Services;

using Introduction.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSingleton<ISingletonCoffee, CoffeeService>();

//builder.Services.AddScoped<IScopedCoffee, CoffeeService>();


//builder.Services.AddTransient<ITransientCoffee, CoffeeService>();







var app = builder.Build();


app.UseMiddleware<HttpContextMiddleware>();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
