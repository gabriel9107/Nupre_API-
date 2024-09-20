using Microsoft.EntityFrameworkCore;
using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionalesEspecialidadesTrans : IRepositorioProfesionalesEspecialidadesTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioProfesionalesEspecialidadesTrans(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<Profesionales_Solicitudes_Especialidades_Trans> obtenerTitulacionPorId(int numero_Solicitud)
        {
            return await context.Profesionales_Solicitudes_Especialidades_Trans.Where(x => x.Solicitud_Numero == numero_Solicitud && x.Registro_Estado == "A").FirstOrDefaultAsync();
        }

        public async Task<List<Profesionales_Solicitudes_Especialidades_Trans>> obtenerTitulacionPorSolicitud(int numero_Solicitud)
        {

            //var query = context.Profesionales_Solicitudes_Especialidades_Trans.Include(p => p.Profesionales_Especialidades_Tipos_Cata).Where(x => x.Solicitud_Numero == numero_Solicitud && x.Registro_Estado == "A").ToListAsync(); 

            //var Ltitulos = Profesion_Especialidad_DTO {


            //}


            return await context.Profesionales_Solicitudes_Especialidades_Trans.Where(x => x.Solicitud_Numero == numero_Solicitud && x.Registro_Estado == "A").ToListAsync();
        }

        public async Task<int> Crear(Profesionales_Solicitudes_Especialidades_Trans trans)
        {


            trans.Registro_Usuario = "g.montero";
            trans.Registro_Estado = "A";
            trans.Especialidad_Estado_Numero = 1;


            byte Especialidad_Tipo_Numero = await context.Profesionales_Especialidades_Cata.Where(x => x.Especialidad_Numero == trans.Especialidad_Numero).Select(s => s.Especialidad_Tipo_Numero).FirstOrDefaultAsync();
            trans.Especialidad_Tipo_Numero = Especialidad_Tipo_Numero;

            context.Add(trans);
            await context.SaveChangesAsync();
            return trans.Solicitud_Numero;
        }

        public async Task Actualizar(Profesionales_Solicitudes_Especialidades_Trans trans)
        {
            context.Update(trans);
            await context.SaveChangesAsync();
        }

    }
}
