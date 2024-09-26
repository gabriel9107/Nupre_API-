using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioProfesionales_Solicitudes_Localidades_Tran 
    {
        Task<Profesionales_Solicitudes_Localidades_Tran> obtenerId(int solicitud_numero);
        Task<Profesionales_Solicitudes_Localidades_Tran> Crear(Profesionales_Solicitudes_Localidades_Tran trans);
        Task<Profesionales_Solicitudes_Localidades_Tran> Actualizar(Profesionales_Solicitudes_Localidades_Tran tran);
        Task<bool> Existe(int id);
    }
}
