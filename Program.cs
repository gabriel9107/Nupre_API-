using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Nupre_API;
using Nupre_API.Endpoints;
using Nupre_API.Entidades;
using Nupre_API.Migrations;
using Nupre_API.Repositorio;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(optciones => optciones.UseSqlServer("name=DefaultConnection"));


builder.Services.AddCors(opciones =>
opciones.AddDefaultPolicy(configuacion =>
{
    configuacion.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddOutputCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioProfesionalesSolicitudesTrans, RepositorioProfesionalesSolcitiudesTrans>();
//Fin area de servicios 
var app = builder.Build();
//inicio del middleware
if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
//Agregamos el uso del cache del servidor para eliminar las llamadas repetidas a la base de datos 
app.UseOutputCache();
app.MapGet("/", () => "Hello World!").CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)));
app.MapGroup("/solicitudes").mapSolicitudes();

app.Run();
