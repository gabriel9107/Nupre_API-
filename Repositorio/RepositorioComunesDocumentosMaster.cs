using Microsoft.EntityFrameworkCore;
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


        public async Task<string> obtenerRutaDocumento(Documento_filtro trans)
        {

            var query = await  context.Profesionales_Solicitudes_Trans.Where(a => a.Solicitud_Numero == trans.Solicitud_numero && a.Registro_Estado == "A").FirstOrDefaultAsync(); 
                if  (query == null) { return null; }

            return await context.Profesionales_Documento_Masters.Where(x => x.Solicitud_Numero == trans.Solicitud_numero && x.Tipo_Documento == trans.Tipo && x.Documento_Codigo == trans.documento_numero).Select(a => a.Documento_ruta).FirstOrDefaultAsync() ;
        }

        public async Task<string> obtenerRutaDocumentoByid(int id)
        {
            var resultado =  await context.Profesionales_Documento_Masters.Where(x => x.Documento_Codigo == id).Select( a => a.Documento_ruta).FirstOrDefaultAsync();
            if (resultado == null)
            {
                return null;
            }
            return resultado; 
        }


        

        public async Task<int> CrearDocumento(CrearDocumentoComun_DTO documento)
        {
            var _documento = new Profesionales_Documento_Master()
            {
                Solicitud_Numero = documento.solicitud_numero, 
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
