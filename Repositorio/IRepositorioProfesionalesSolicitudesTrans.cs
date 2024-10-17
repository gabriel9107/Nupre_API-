using Nupre_API.DTOs;
using Nupre_API.Entidades;


namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesSolicitudesTrans
    {

        Task<List<Profesionales_Solicitudes_Tran>> getrequestsbyuser(Profesionales_Filtro_Listado_DTO filtro) ;
        Task<List<Profesionales_Solicitudes_Tran>> ObtenerTodos();
        Task<Profesionales_Solicitudes_Tran> ObtenerPorId(int id); 
        Task<int> Crear(Profesionales_Solicitudes_Tran profesionales);
        Task<bool> SometerSolicitud(int id);
        Task<bool> Existe(int id);
        Task Actualizar(Profesionales_Solicitudes_Tran profesionales); 


    }
}
