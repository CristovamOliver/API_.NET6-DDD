using Application.Interface;
using Application.Service;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvcCore().AddApiExplorer();

//// AppService
//builder.Services.AddTransient<ICarroAppService, CarroAppService>();
builder.Services.AddScoped<IMarcaAppService, MarcaAppService>();
//builder.Services.AddTransient<IUsuarioAppService, UsuarioAppService>();


//// Service
//builder.Services.AddTransient<ICarroService, CarroService>();
builder.Services.AddScoped<IMarcaService, MarcaService>();
//builder.Services.AddTransient<IUsuarioService, UsuarioService>();

//// Repository
//builder.Services.AddTransient<ICarroRepository, CarroRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
//builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

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
