using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;
using System.Reflection.Metadata.Ecma335;

namespace Nupre_API.Repositorio
{
    public class RepositorioDocumentoTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioDocumentoTrans(ApplicationDbContext contex)
        {
            context = contex;
        }

        public async Task<List<Profesionales_Documento_Master>> obtenerDocumento()
        {
            return await context.Profesionales_Documento_Masters.Where(documento => documento.Registro_Estado == "A").ToListAsync();
        }
        public async Task<Profesionales_Documento_Master> obtenerDocumentoPorTipo(int documentId)
        {

            return await context.Profesionales_Documento_Masters.Where(documento => documento.Documento_Codigo == documentId).FirstOrDefaultAsync();
        }

        public async Task<int> Crear(Profesionales_Documento_Master documento)
        {
            context.Add(documento);
            await context.SaveChangesAsync();
            return documento.Documento_Codigo;
        }

        public async Task Actualizar(Profesionales_Documento_Master documento)
        {
            context.Update(documento);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Profesionales_Documento_Masters.AnyAsync(x => x.Documento_Codigo == id);
        }


    }
}
