using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioSolicitudes_Actividades_Trans
    {
        Task<Solicitudes_Actividades_Trans> crear(Solicitudes_Actividades_Trans actividad);
    }
}
