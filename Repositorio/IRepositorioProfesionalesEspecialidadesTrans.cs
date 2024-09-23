using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesEspecialidadesTrans
    {
        Task<Profesionales_Solicitudes_Especialidades_Trans> obtenerTitulacionPorId(int numero_Solicitud);
        Task<List<DetalleProfesionales_DTO>> ObtenerTitulacionPorSolicitud(int numero_Solicitud);
        Task<int> Crear(Profesionales_Solicitudes_Especialidades_Trans trans);
        Task Actualizar(Profesionales_Solicitudes_Especialidades_Trans trans);

    }
}