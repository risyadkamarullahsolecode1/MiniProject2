using Microsoft.OpenApi.Models;
using MiniProject2.Interfaces;
using MiniProject2.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<IMenuServices, MenuServices>();
builder.Services.AddSingleton<ICustomerServices, CustomerServices>();
builder.Services.AddSingleton<IOrderServices, OrderServices>();

//Swagger Documentation Section
var info = new OpenApiInfo()
{
    Title = "Mini Project 2 Web API Documentation",
    Version = "v1",
    Description = "Web Net.Core API",
    Contact = new OpenApiContact()
    {
        Name = "Risyad",
        Email = "risyad.kamarullah@solecode.id",
    }

};

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", info);

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(u =>
    {
        u.RouteTemplate = "swagger/{documentName}/swagger.json";
    });

    app.UseSwaggerUI(c =>
    {
        c.RoutePrefix = "swagger";
        c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "Mini Project 2 Web API Documentation");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
