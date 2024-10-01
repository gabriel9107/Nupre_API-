using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Nupre_API;
using Nupre_API.Endpoints;
using Nupre_API.Entidades;

using Nupre_API.Models;
using Nupre_API.Repositorio;
using Nupre_API.Servicios;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseKestrel(o => o.Limits.MaxRequestBodySize = null);


builder.Services.AddDbContext<ApplicationDbContext>(optciones => optciones.UseSqlServer("name=DefaultConnection"));
builder.Services.AddDbContext<SimonContext>(optciones => optciones.UseSqlServer("name=SimonConnection"));

    
builder.Services.AddCors(opciones =>
opciones.AddDefaultPolicy(configuacion =>
{
    configuacion.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddOutputCache();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioProfesionalesSolicitudesTrans, RepositorioProfesionalesSolcitiudesTrans>();
builder.Services.AddScoped<IRepositorioProfesionalesEspecialidadesCata, RepositorioProfesionalesEspecialidadesCata>();
builder.Services.AddScoped<IRepositorioCiudadanoTrans, RepositorioCiudadanoTrans>();
builder.Services.AddScoped<IRepositorioMunicipioTrans, RepositorioMunicipioTrans>();
builder.Services.AddScoped<IRepositorioNacionalidad, RepositorioNacionalidad>();
builder.Services.AddScoped<IRepositorioEstadoCata, RepositorioEstadoCata>();
builder.Services.AddScoped<IRepositorioProfesionalesEspecialidadesTrans, RepositorioProfesionalesEspecialidadesTrans>();
builder.Services.AddScoped<IRepositorioComunesDocumentosMaster, RepositorioComunesDocumentosMaster>();
builder.Services.AddScoped<IRepositorioProfesionalesAsociacionesTrans, RepositorioProfesionalesAsociacionesTrans>();
builder.Services.AddScoped<IRepositorioProfesionales_Solicitudes_Localidades_Tran, RepositorioProfesionales_Solicitudes_Localidades_Tran>();
builder.Services.AddScoped<IRepositorioSolicitudes_Actividades_Trans, RepositorioSolicitudes_Actividades_Trans>();


builder.Services.AddScoped<IAlmacenadorArchivos, AlmacenadorArchivosLocal>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddAntiforgery();







builder.Services.AddAutoMapper(typeof(Program));

//Fin area de servicios 
var app = builder.Build();
//inicio del middleware
if (builder.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseStaticFiles();




app.UseCors();
//Agregamos el uso del cache del servidor para eliminar las llamadas repetidas a la base de datos 
app.UseOutputCache();
app.MapGet("/", () => "Hello World!").CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)));
app.MapGroup("/solicitudes").mapSolicitudes();
app.MapGroup("/titulacion").mapProfesionalesEspecialidades();
app.MapGroup("/profesiones").mapProfesionales();
app.MapGroup("/utilidades").mapUtilidades();
app.MapGroup("/ciudadano").mapCiudadano();
app.MapGroup("/asociaciones/").mapAsociaciones();
app.MapGroup("/localidades").mapProfesionales_Solicitudes_Localidades();





app.Run();
 