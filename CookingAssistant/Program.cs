using CookingAssistant.Services.Protobuf;
using CookingAssistant.Handlers.Implementations;
using CookingAssistant.Handlers.Interfaces;
using CookingAssistant.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ICookerHandler<Recipe, Ingredient>, CookerHandler>();
// Add services to the container.
builder.Services.AddGrpc().AddJsonTranscoding();;

var app = builder.Build();

app.UseRequestLocalization();

// Configure the HTTP request pipeline.
app.MapGrpcService<CookerService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();