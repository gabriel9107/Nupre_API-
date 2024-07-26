using Nupre_API.Entidades;


namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionalesSolicitudesTrans
    {
        Task<List<ProfesionalesSolicitudesTran>> ObtenerTodos();
        Task<ProfesionalesSolicitudesTran> ObtenerPorId(int id); 
        Task<int> Crear(ProfesionalesSolicitudesTran profesionales);
        Task<bool> Existe(int id);
        Task Actualizar(ProfesionalesSolicitudesTran profesionales); 


    }
}
