using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionalesAsociacionesTrans : IRepositorioProfesionalesAsociacionesTrans
    {
        private readonly ApplicationDbContext context; 
        public RepositorioProfesionalesAsociacionesTrans(ApplicationDbContext context)
        {

            this.context = context;

        }
        public async Task<int> Crear(Profesionales_Solicitudes_Asociaciones_Tran trans)
        {
            context.Add(trans); 
            await context.SaveChangesAsync();
            return trans.Solicitud_Numero; 
        }


        public async Task<List<Profesionales_Solicitudes_Asociaciones_Tran>> obtenerTodos( int number )
        {
            return await context.Profesionales_Solicitudes_Asociaciones_Trans.Where( x => x.Solicitud_Numero == number && x.Registro_Estado == "A").ToListAsync();    
            
        }


        public async Task<Profesionales_Solicitudes_Asociaciones_Tran> obtenerAsociacionPorId(int number)
        {
            return await context.Profesionales_Solicitudes_Asociaciones_Trans.Where(x => x.Solicitud_Numero == number && x.Registro_Estado == "A").FirstOrDefaultAsync();

        }

        public async Task<List<Profesionales_Asociaciones_Tipo_Cata>> obtenerListadoDeAsociaciones()
        {
            return await context.Profesionales_Asociaciones_Catas.ToListAsync();   
        }

       
    }
}
