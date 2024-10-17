
using Microsoft.AspNetCore.Mvc;
using Nupre_API.DTOs;
using Nupre_API.Models;
using Nupre_API.Utilidades;

namespace Nupre_API.Servicios
{
    public class AlmacenadorArchivosLocal : IAlmacenadorArchivos
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IWebHostEnvironment env; 

        public AlmacenadorArchivosLocal(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            this.env = env;             
            this.httpContextAccessor = httpContextAccessor;
        }

        public IWebHostEnvironment Env { get; }

        public async Task<string> Almacenar(string contenedor, IFormFile archivo)
        {
            var extension = Path.GetExtension(archivo.FileName);
            var nombreArchivo = $"{ Guid.NewGuid()}{ extension}" ;
            string folder = Path.Combine(env.WebRootPath, contenedor);

            string ruta = Path.Combine(folder, nombreArchivo);

            using (var ms = new MemoryStream()) { 
                await archivo.CopyToAsync(ms);
                var contendido = ms.ToArray();
                await File.WriteAllBytesAsync(ruta, contendido);
            }

            var url = $"{httpContextAccessor.HttpContext!.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var urlArchivo = Path.Combine(url, contenedor, nombreArchivo).Replace("\\", "/");
            return urlArchivo;


         }


       



        public async Task<CrearDocumentoComun_DTO> Almacenar_NombreArchivo(string contenedor, IFormFile archivo)
        {
            var extension = Path.GetExtension(archivo.FileName);
            var nombreArchivo = $"{Guid.NewGuid()}{extension}";
            string folder = Path.Combine(env.WebRootPath, contenedor);

            string ruta = Path.Combine(folder, nombreArchivo);

            using (var ms = new MemoryStream())
            {
                await archivo.CopyToAsync(ms);
                var contendido = ms.ToArray();
                await File.WriteAllBytesAsync(ruta, contendido);
            }

            var url = $"{httpContextAccessor.HttpContext!.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var urlArchivo = Path.Combine(url, contenedor, nombreArchivo).Replace("\\", "/");

            var documento = new CrearDocumentoComun_DTO()
            {
                Nombre = nombreArchivo,
                Documento_ruta = ruta
                

            };
            return documento;


        }

        public Task Borrar(string? ruta, string contenedor)
        {
            if (string.IsNullOrEmpty(ruta))
            {
                return Task.CompletedTask;
                
            }
            var nombreArchivo = Path.GetFileName(ruta);
            var directorioArchivo = Path.Combine(env.WebRootPath, contenedor, nombreArchivo);
            if(File.Exists(directorioArchivo))
            {
                File.Delete(directorioArchivo);
            }

            return Task.CompletedTask;

        }
    }
}
