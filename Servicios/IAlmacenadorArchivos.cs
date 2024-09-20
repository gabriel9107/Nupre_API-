using Microsoft.AspNetCore.Http;
using Nupre_API.DTOs;

namespace Nupre_API.Servicios
{
    public interface IAlmacenadorArchivos
    {
        Task Borrar(string? ruta, string contenedor);
          Task<string> Almacenar(string contenedor, IFormFile archivo);

        
        Task<CrearDocumentoComun_DTO> Almacenar_NombreArchivo(string contenedor, IFormFile archivo);
        async Task<string> Editar(string ruta, string contenedor, IFormFile archivo)
        {
            await Borrar(ruta, contenedor);
            return await Almacenar(contenedor, archivo);

        }
    }
}
