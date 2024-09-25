using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesAsociacionesTrans
    {
        Task<int> Crear(Profesionales_Solicitudes_Asociaciones_Tran trans);
        Task<List<Profesionales_Solicitudes_Asociaciones_Tran>> obtenerTodos(int number);
        Task<Profesionales_Solicitudes_Asociaciones_Tran> obtenerAsociacionPorId(int number);

        Task<List<Profesionales_Asociaciones_Tipo_Cata>> obtenerListadoDeAsociaciones();
    }
}
