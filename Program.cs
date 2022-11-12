using Microsoft.EntityFrameworkCore;
using PaymentAPI.Context;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Usando EntentyFrameworkCore.InMemory
//Para simular uma db na ram
builder.Services
    .AddDbContext<PaymentContext>(options => options
    .UseInMemoryDatabase("dbLoja"));


builder.Services.AddControllers()
    //comando para converter as enums em string
    //para a seleção no swagger ficar mais visual.
    .AddJsonOptions(options =>
    options.JsonSerializerOptions
    .Converters.Add(new JsonStringEnumConverter()));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
