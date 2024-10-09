using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesActividadesTrans
    {

        Task<bool> existe(int Solicitud_Numero, int actividad_numero);
        Task<Solicitudes_Actividades_Trans> Crear(Solicitudes_Actividades_Trans trans);
        Task<List<Solicitudes_Actividades_Trans>> obtenerActididades(Solicitudes_Actividades_Trans trans);
        Task<Solicitudes_Actividades_Trans> obtenerActididadesPorSolicitud(Solicitudes_Actividades_Trans trans);
        Task<List<Solicitudes_Actividades_Progress_DTO>> obtener_Progreso_solicitudes(int Solicitud_Numero);
    }
}
