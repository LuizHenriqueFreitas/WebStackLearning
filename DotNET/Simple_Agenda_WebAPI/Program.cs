using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Simple_Agenda_WebAPI.Context;

var builder = WebApplication.CreateBuilder(args);

// 1. Configuração do banco SQLite (ou UseSqlServer, dependendo do banco usado)
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// 2. Registro dos Controllers + conversão de Enums para String no JSON
builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

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

// 4. Mapeamento das rotas dos Controllers
app.MapControllers();

app.Run();