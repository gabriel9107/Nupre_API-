using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionales_Solicitudes_Localidades_Tran : IRepositorioProfesionales_Solicitudes_Localidades_Tran
    {
        private readonly ApplicationDbContext context; 
        public RepositorioProfesionales_Solicitudes_Localidades_Tran(ApplicationDbContext context)
        {
           this.context = context;
        }


        public async Task<List<Profesionales_Solicitudes_Localidades_Tran>> ObtenerListaLocalidadesPoId(int solicitud_numero)
        {
            return await context.Profesionales_Solicitudes_Localidades_Trans.Where(x => x.Solicitud_Numero == solicitud_numero).ToListAsync();
        }


        public async Task<Profesionales_Solicitudes_Localidades_Tran> obtenerId(int solicitud_numero)
        {
            return await context.Profesionales_Solicitudes_Localidades_Trans.Where(x => x.Solicitud_Numero == solicitud_numero).FirstOrDefaultAsync();
        }

        public async Task<Profesionales_Solicitudes_Localidades_Tran> Crear(Profesionales_Solicitudes_Localidades_Tran trans)
        {


            trans.Registro_Fecha = DateTime.Now;
            trans.Registro_Estado = "A";
            trans.Registro_Usuario = "g.montero";
        


            context.Add(trans);
            await context.SaveChangesAsync();
            return trans;

        }

        public async Task<Profesionales_Solicitudes_Localidades_Tran> Actualizar(Profesionales_Solicitudes_Localidades_Tran tran)
        {
            context.Update(tran);
            await context.SaveChangesAsync();
            return tran;
        }

        public async Task<bool> Existe(int id)
        {
            return await context.Profesionales_Solicitudes_Localidades_Trans.AnyAsync(x => x.Solicitud_Numero == id);
        }
    }
}
