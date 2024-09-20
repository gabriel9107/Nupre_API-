using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioComunesDocumentosMaster  : IRepositorioComunesDocumentosMaster

    {
        private readonly ApplicationDbContext context;
        public RepositorioComunesDocumentosMaster(ApplicationDbContext context)
        {

            this.context = context;
        }

        public async Task<int> CrearDocumento(CrearDocumentoComun_DTO documento)
        {
            var _documento = new Profesionales_Documento_Master()
            {
                Nombre = documento.Nombre,
                Documento_ruta = documento.Documento_ruta,
                Tipo_Documento = (int)documento.Tipo_Documento!,
                Registro_Fecha = new DateTime(2022, 1, 1),
                Registro_Estado = "A",
                Registro_Usuario = "g.montero",
                Descripcion = "n/"


            };

            context.Add(_documento);    
            await context.SaveChangesAsync();
            return _documento.Documento_Codigo;
            

        }
    }
}
