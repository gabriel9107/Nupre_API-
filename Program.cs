using Microsoft.EntityFrameworkCore;
using Nupre_API;

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

app.Run();
