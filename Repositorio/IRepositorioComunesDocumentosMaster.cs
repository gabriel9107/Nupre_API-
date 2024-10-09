using Nupre_API.DTOs;

namespace Nupre_API.Repositorio
{
    public interface IRepositorioComunesDocumentosMaster
    {
        Task<int> CrearDocumento(CrearDocumentoComun_DTO documento);
        Task<string> obtenerRutaDocumento(Documento_filtro trans);
    }
}