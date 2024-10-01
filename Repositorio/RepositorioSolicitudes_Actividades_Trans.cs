
using AutoMapper;
using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioSolicitudes_Actividades_Trans : IRepositorioSolicitudes_Actividades_Trans
    {
        private readonly ApplicationDbContext context;
        public RepositorioSolicitudes_Actividades_Trans(ApplicationDbContext context)
        {
           this.context = context;  
        }
    
        public async Task<Solicitudes_Actividades_Trans> crear(Solicitudes_Actividades_Trans actividad)
        {
            
            context.Add(actividad);
            await context.SaveChangesAsync();
            return actividad;
        }
        
    }

}
