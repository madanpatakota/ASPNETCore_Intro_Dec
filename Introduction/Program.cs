
//using Introduction.Interfaces;
//using Introduction.Services;

//using Introduction.Extensions;
using Introduction.Contracts;
using Introduction.Middleware;
using Introduction.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSingleton<ISingletonCoffee, CoffeeService>();

//builder.Services.AddScoped<IScopedCoffee, CoffeeService>();


//builder.Services.AddTransient<ITransientCoffee, CoffeeService>();


builder.Services.AddSingleton<IAuthenticateServcie, AutheticationService>();
builder.Services.AddSingleton<IJWTAuthenticatoin, JWTAuthenticationService>();




var app = builder.Build();


//app.UseMiddleware<HttpContextMiddleware>();
//app.UseMiddleware<AuthenticationMiddleware>();


app.UseMiddleware<JWTAuthenticationMiddleware>();


//1 st middleware
//app.UseHttpContextMiddlewareDemo();


//2 nd more middleware
//app.UseLoggingContextMiddlewareDemo();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
