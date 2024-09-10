using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesEspecialidadesTrans
    {
        Task<Profesionales_Solicitudes_Especialidades_Trans> obtenerTitulacionPorId(int numero_Solicitud);
        Task<List<Profesionales_Solicitudes_Especialidades_Trans>> obtenerTitulacionPorSolicitud(int numero_Solicitud);
        Task<int> Crear(Profesionales_Solicitudes_Especialidades_Trans trans);
        Task Actualizar(Profesionales_Solicitudes_Especialidades_Trans trans);

    }
}