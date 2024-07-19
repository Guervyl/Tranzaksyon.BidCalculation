using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using System.Text.Json;
using Tranzaksyon.BidCalculation.Api.Formatters;

var builder = WebApplication.CreateBuilder(args);

var OriginClientePolicy = "OriginClientePolicy";

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: OriginClientePolicy,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5173")
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowCredentials();
                      });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<VehiculeInputJsonFormatter>();

var app = builder.Build();

// Add the vehicule input formatter
var mvcOptions = app.Services.GetRequiredService<IOptions<MvcOptions>>();
mvcOptions.Value.InputFormatters.Insert(0, app.Services.GetRequiredService<VehiculeInputJsonFormatter>());

app.UseCors(OriginClientePolicy);

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
