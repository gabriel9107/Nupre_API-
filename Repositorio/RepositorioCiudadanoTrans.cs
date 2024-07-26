using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioCiudadanoTrans : IRepositorioCiudadanoTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioCiudadanoTrans(ApplicationDbContext context)
        {

            this.context = context;
        }

        public async Task<TssCiudadanosMaster> obtenerCiudadano(string ndocumento)
        {
            return await context.TSS_Ciudadanos_Master.Where( x => x.RegistroEstado =="A" && x.CiudadanoNoDocumento == ndocumento).FirstOrDefaultAsync();   
        }

        public async Task<bool> Existe(string Ndocumento)
        {
            return await context.TSS_Ciudadanos_Master.Where(x => x.RegistroEstado == "A")
                .AnyAsync(x => x.CiudadanoNoDocumento == Ndocumento);
        }



    }
}
