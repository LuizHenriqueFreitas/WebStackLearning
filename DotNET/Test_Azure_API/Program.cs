using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Test_Azure_API.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ContextDataBase>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();