using Microsoft.EntityFrameworkCore;
using Nupre_API.DTOs;
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

        public async Task<TssCiudadanosMaster> obtenerCiudadanoFiltrado(Ciudadano_FiltroDTO filtro)
        {


            var verificar = await context.Profesionales_Solicitudes_Trans.Where(a => a.Profesional_Cedula == filtro.Cedula).FirstOrDefaultAsync();


            if (verificar is not null)
            {
                 throw new InvalidOperationException($"Esiste un registro pendiente del afiliado Cedula : {filtro.Cedula}");
            }

            var resultado = new TssCiudadanosMaster();


            var nss = context.TSS_Ciudadanos_Master.Where(c => c.CiudadanoNoDocumento == filtro.Cedula)
           .FirstOrDefault();

            if(nss is null)
            {


                throw new InvalidOperationException($"No existe la cedula : {filtro.Cedula} consultada");
                
            }

            //verificamos si la persona esta en la empresa que esta realizando el registro 
                
            if (filtro.Empleador_Registro_Patronal is not null)
            {
                var query = await context.TSS_Trabajadores_Trans.Where(s => s.Empleador_Registro_Patronal == filtro.Empleador_Registro_Patronal && s.Trabajador_Nss == nss.CiudadanoNss).FirstOrDefaultAsync();
                if (query != null)
                {
                return resultado = await context.TSS_Ciudadanos_Master.Where(s => s.CiudadanoNoDocumento == filtro.Cedula).FirstOrDefaultAsync(); 

                }
                 throw new InvalidOperationException($"No existe este Profesional con la cedula : {filtro.Cedula} relacionado en su entidad");

                 
            }
            resultado = await context.TSS_Ciudadanos_Master.Where(s => s.CiudadanoNoDocumento == filtro.Cedula).FirstOrDefaultAsync();

            return resultado;

        }
    }
}
